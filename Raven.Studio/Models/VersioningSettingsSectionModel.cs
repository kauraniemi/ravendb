﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Expression.Interactivity.Core;
using Raven.Abstractions.Data;
using Raven.Abstractions.Replication;
using Raven.Bundles.Versioning.Data;
using Raven.Client.Linq;
using Raven.Studio.Commands;
using Raven.Studio.Infrastructure;

namespace Raven.Studio.Models
{
    public class VersioningSettingsSectionModel : SettingsSectionModel
    {
        public VersioningSettingsSectionModel()
        {
            OriginalVersioningConfigurations = new ObservableCollection<VersioningConfiguration>();
            VersioningConfigurations = new ObservableCollection<VersioningConfiguration>();
            VersioningConfigurations.CollectionChanged += (sender, args) => OnPropertyChanged(() => HasDefaultVersioning);
            SectionName = "Versioning";
        }


        public VersioningConfiguration SeletedVersioning { get; set; }

        public ObservableCollection<VersioningConfiguration> OriginalVersioningConfigurations { get; set; }
        public ObservableCollection<VersioningConfiguration> VersioningConfigurations { get; set; }

        public bool HasDefaultVersioning
        {
            get { return VersioningConfigurations.Any(configuration => configuration.Id == "Raven/Versioning/DefaultConfiguration"); }
        }


        private ICommand addVersioningCommand;
        private ICommand deleteVersioningCommand;

        public ICommand DeleteVersioning
        {
            get { return deleteVersioningCommand ?? (deleteVersioningCommand = new ActionCommand(HandleDeleteVersioning)); }
        }

        public ICommand AddVersioning
        {
            get
            {
                return addVersioningCommand ??
                       (addVersioningCommand =
                        new ActionCommand(() => VersioningConfigurations.Add(new VersioningConfiguration())));
            }
        }

        private void HandleDeleteVersioning(object parameter)
        {
            var versioning = parameter as VersioningConfiguration;
            if (versioning == null)
                return;
            VersioningConfigurations.Remove(versioning);
            SeletedVersioning = null;
        }

        public override void LoadFor(DatabaseDocument databaseDocument)
        {
            var session = ApplicationModel.Current.Server.Value.DocumentStore.OpenAsyncSession(databaseDocument.Id);
            session                 
               .Query<VersioningConfiguration>().ToListAsync().ContinueOnSuccessInTheUIThread(
                   list =>
                   {
                       VersioningConfigurations.Clear();
                       foreach (var versioningConfiguration in list)
                       {
                           VersioningConfigurations.Add(versioningConfiguration);
                       }
                       foreach (var versioningConfiguration in list)
                       {
                           OriginalVersioningConfigurations.Add(versioningConfiguration);
                       }
                   });

            session
                .LoadAsync<object>("Raven/Versioning/DefaultConfiguration")
                .ContinueOnSuccessInTheUIThread(document =>
                {
                    if (document != null)
                    {
                        VersioningConfigurations.Insert(0, document as VersioningConfiguration);
                        OriginalVersioningConfigurations.Insert(0, document as VersioningConfiguration);
                        OnPropertyChanged(() => HasDefaultVersioning);
                    }
                });
        }
    }
}