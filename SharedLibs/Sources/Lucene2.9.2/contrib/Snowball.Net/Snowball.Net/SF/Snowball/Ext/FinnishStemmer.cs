/* 
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

// This file was generated automatically by the Snowball to Java compiler
using System;
using Among = SF.Snowball.Among;
using SnowballProgram = SF.Snowball.SnowballProgram;
namespace SF.Snowball.Ext
{
	
	/// <summary> Generated class implementing code defined by a snowball script.</summary>
	public class FinnishStemmer:SnowballProgram
	{
		public FinnishStemmer()
		{
			InitBlock();
		}
		private void  InitBlock()
		{
			a_0 = new Among[]{new Among("pa", - 1, 1, "", this), new Among("sti", - 1, 2, "", this), new Among("kaan", - 1, 1, "", this), new Among("han", - 1, 1, "", this), new Among("kin", - 1, 1, "", this), new Among("h\u00E4n", - 1, 1, "", this), new Among("k\u00E4\u00E4n", - 1, 1, "", this), new Among("ko", - 1, 1, "", this), new Among("p\u00E4", - 1, 1, "", this), new Among("k\u00F6", - 1, 1, "", this)};
			a_1 = new Among[]{new Among("lla", - 1, - 1, "", this), new Among("na", - 1, - 1, "", this), new Among("ssa", - 1, - 1, "", this), new Among("ta", - 1, - 1, "", this), new Among("lta", 3, - 1, "", this), new Among("sta", 3, - 1, "", this)};
			a_2 = new Among[]{new Among("ll\u00E4", - 1, - 1, "", this), new Among("n\u00E4", - 1, - 1, "", this), new Among("ss\u00E4", - 1, - 1, "", this), new Among("t\u00E4", - 1, - 1, "", this), new Among("lt\u00E4", 3, - 1, "", this), new Among("st\u00E4", 3, - 1, "", this)};
			a_3 = new Among[]{new Among("lle", - 1, - 1, "", this), new Among("ine", - 1, - 1, "", this)};
			a_4 = new Among[]{new Among("nsa", - 1, 3, "", this), new Among("mme", - 1, 3, "", this), new Among("nne", - 1, 3, "", this), new Among("ni", - 1, 2, "", this), new Among("si", - 1, 1, "", this), new Among("an", - 1, 4, "", this), new Among("en", - 1, 6, "", this), new Among("\u00E4n", - 1, 5, "", this), new Among("ns\u00E4", - 1, 3, "", this)};
			a_5 = new Among[]{new Among("aa", - 1, - 1, "", this), new Among("ee", - 1, - 1, "", this), new Among("ii", - 1, - 1, "", this), new Among("oo", - 1, - 1, "", this), new Among("uu", - 1, - 1, "", this), new Among("\u00E4\u00E4", - 1, - 1, "", this), new Among("\u00F6\u00F6", - 1, - 1, "", this)};
			a_6 = new Among[]{new Among("a", - 1, 8, "", this), new Among("lla", 0, - 1, "", this), new Among("na", 0, - 1, "", this), new Among("ssa", 0, - 1, "", this), new Among("ta", 0, - 1, "", this), new Among("lta", 4, - 1, "", this), new Among("sta", 4, - 1, "", this), new Among("tta", 4, 9, "", this), new Among("lle", - 1, - 1, "", this), new Among("ine", - 1, - 1, "", this), new Among("ksi", - 1, - 1, "", this), new Among("n", - 1, 7, "", this), new Among("han", 11, 1, "", this), new Among("den", 11, - 1, "r_VI", this), new Among("seen", 11, - 1, "r_LONG", this), new Among("hen", 11, 2, "", this), new Among("tten", 11, - 1, "r_VI", this), new Among("hin", 11, 3, "", this), new Among("siin", 11, - 1, "r_VI", this), new Among("hon", 11, 4, "", this), new Among("h\u00E4n", 11, 5, "", this), new Among("h\u00F6n", 11, 6, "", this), new Among("\u00E4", - 1, 8, "", this), new Among("ll\u00E4", 22, - 1, "", this), new Among("n\u00E4", 22, - 1, "", this), new Among("ss\u00E4", 22, - 1, "", this), new Among("t\u00E4", 22, - 1, "", this), new Among("lt\u00E4", 26, - 1, "", this), new Among("st\u00E4", 26, - 1, "", this), new Among("tt\u00E4", 26, 9, "", this)};
			a_7 = new Among[]{new Among("eja", - 1, - 1, "", this), new Among("mma", - 1, 1, "", this), new Among("imma", 1, - 1, "", this), new Among("mpa", - 1, 1, "", this), new Among("impa", 3, - 1, "", this), new Among("mmi", - 1, 1, "", this), new Among("immi", 5, - 1, "", this), new Among("mpi", - 1, 1, "", this), new Among("impi", 7, - 1, "", this), new Among("ej\u00E4", - 1, - 1, "", this), new Among("mm\u00E4", - 1, 1, "", this), new Among("imm\u00E4", 10, - 1, "", this), new Among("mp\u00E4", - 1, 1, "", this), new Among("imp\u00E4", 12, - 1, "", this)};
			a_8 = new Among[]{new Among("i", - 1, - 1, "", this), new Among("j", - 1, - 1, "", this)};
			a_9 = new Among[]{new Among("mma", - 1, 1, "", this), new Among("imma", 0, - 1, "", this)};
		}
		
		private Among[] a_0;
		private Among[] a_1;
		private Among[] a_2;
		private Among[] a_3;
		private Among[] a_4;
		private Among[] a_5;
		private Among[] a_6;
		private Among[] a_7;
		private Among[] a_8;
		private Among[] a_9;

        private static readonly char[] g_AEI = new char[]{(char) (17), (char) (1), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (8)};
		private static readonly char[] g_v = new char[]{(char) (17), (char) (65), (char) (16), (char) (1), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (8), (char) (0), (char) (32)};
		private static readonly char[] g_V = new char[]{(char) (17), (char) (65), (char) (16), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (8), (char) (0), (char) (32)};
		private static readonly char[] g_particle_end = new char[]{(char) (17), (char) (97), (char) (24), (char) (1), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (0), (char) (8), (char) (0), (char) (32)};
		
		private bool B_ending_removed;
		private System.Text.StringBuilder S_x = new System.Text.StringBuilder();
		private int I_p2;
		private int I_p1;
		
		protected internal virtual void  copy_from(FinnishStemmer other)
		{
			B_ending_removed = other.B_ending_removed;
			S_x = other.S_x;
			I_p2 = other.I_p2;
			I_p1 = other.I_p1;
			base.copy_from(other);
		}
		
		private bool r_mark_regions()
		{
			int v_1;
			int v_3;
			// (, line 41
			I_p1 = limit;
			I_p2 = limit;
			// goto, line 46
			while (true)
			{
				v_1 = cursor;
				do 
				{
					if (!(in_grouping(g_v, 97, 246)))
					{
						goto lab1_brk;
					}
					cursor = v_1;
					goto golab0_brk;
				}
				while (false);

lab1_brk: ;
				
				cursor = v_1;
				if (cursor >= limit)
				{
					return false;
				}
				cursor++;
			}

golab0_brk: ;
			
			// gopast, line 46
			while (true)
			{
				do 
				{
					if (!(out_grouping(g_v, 97, 246)))
					{
						goto lab3_brk;
					}
					goto golab2_brk;
				}
				while (false);

lab3_brk: ;
				
				if (cursor >= limit)
				{
					return false;
				}
				cursor++;
			}

golab2_brk: ;
			
			// setmark p1, line 46
			I_p1 = cursor;
			// goto, line 47
			while (true)
			{
				v_3 = cursor;
				do 
				{
					if (!(in_grouping(g_v, 97, 246)))
					{
						goto lab5_brk;
					}
					cursor = v_3;
					goto golab4_brk;
				}
				while (false);

lab5_brk: ;
				
				cursor = v_3;
				if (cursor >= limit)
				{
					return false;
				}
				cursor++;
			}

golab4_brk: ;
			
			// gopast, line 47
			while (true)
			{
				do 
				{
					if (!(out_grouping(g_v, 97, 246)))
					{
						goto lab7_brk;
					}
					goto golab6_brk;
				}
				while (false);

lab7_brk: ;
				
				if (cursor >= limit)
				{
					return false;
				}
				cursor++;
			}

golab6_brk: ;
			
			// setmark p2, line 47
			I_p2 = cursor;
			return true;
		}
		
		private bool r_R2()
		{
			if (!(I_p2 <= cursor))
			{
				return false;
			}
			return true;
		}
		
		private bool r_particle_etc()
		{
			int among_var;
			int v_1;
			int v_2;
			// (, line 54
			// setlimit, line 55
			v_1 = limit - cursor;
			// tomark, line 55
			if (cursor < I_p1)
			{
				return false;
			}
			cursor = I_p1;
			v_2 = limit_backward;
			limit_backward = cursor;
			cursor = limit - v_1;
			// (, line 55
			// [, line 55
			ket = cursor;
			// substring, line 55
			among_var = find_among_b(a_0, 10);
			if (among_var == 0)
			{
				limit_backward = v_2;
				return false;
			}
			// ], line 55
			bra = cursor;
			limit_backward = v_2;
			switch (among_var)
			{
				
				case 0: 
					return false;
				
				case 1: 
					// (, line 62
					if (!(in_grouping_b(g_particle_end, 97, 246)))
					{
						return false;
					}
					break;
				
				case 2: 
					// (, line 64
					// call R2, line 64
					if (!r_R2())
					{
						return false;
					}
					break;
				}
			// delete, line 66
			slice_del();
			return true;
		}
		
		private bool r_possessive()
		{
			int among_var;
			int v_1;
			int v_2;
			int v_3;
			// (, line 68
			// setlimit, line 69
			v_1 = limit - cursor;
			// tomark, line 69
			if (cursor < I_p1)
			{
				return false;
			}
			cursor = I_p1;
			v_2 = limit_backward;
			limit_backward = cursor;
			cursor = limit - v_1;
			// (, line 69
			// [, line 69
			ket = cursor;
			// substring, line 69
			among_var = find_among_b(a_4, 9);
			if (among_var == 0)
			{
				limit_backward = v_2;
				return false;
			}
			// ], line 69
			bra = cursor;
			limit_backward = v_2;
			switch (among_var)
			{
				
				case 0: 
					return false;
				
				case 1: 
					// (, line 72
					// not, line 72
					{
						v_3 = limit - cursor;
						do 
						{
							// literal, line 72
							if (!(eq_s_b(1, "k")))
							{
								goto lab0_brk;
							}
							return false;
						}
						while (false);

lab0_brk: ;
						
						cursor = limit - v_3;
					}
					// delete, line 72
					slice_del();
					break;
				
				case 2: 
					// (, line 74
					// delete, line 74
					slice_del();
					// [, line 74
					ket = cursor;
					// literal, line 74
					if (!(eq_s_b(3, "kse")))
					{
						return false;
					}
					// ], line 74
					bra = cursor;
					// <-, line 74
					slice_from("ksi");
					break;
				
				case 3: 
					// (, line 78
					// delete, line 78
					slice_del();
					break;
				
				case 4: 
					// (, line 81
					// among, line 81
					if (find_among_b(a_1, 6) == 0)
					{
						return false;
					}
					// delete, line 81
					slice_del();
					break;
				
				case 5: 
					// (, line 83
					// among, line 83
					if (find_among_b(a_2, 6) == 0)
					{
						return false;
					}
					// delete, line 84
					slice_del();
					break;
				
				case 6: 
					// (, line 86
					// among, line 86
					if (find_among_b(a_3, 2) == 0)
					{
						return false;
					}
					// delete, line 86
					slice_del();
					break;
				}
			return true;
		}
		
		private bool r_LONG()
		{
			// among, line 91
			if (find_among_b(a_5, 7) == 0)
			{
				return false;
			}
			return true;
		}
		
		private bool r_VI()
		{
			// (, line 93
			// literal, line 93
			if (!(eq_s_b(1, "i")))
			{
				return false;
			}
			if (!(in_grouping_b(g_V, 97, 246)))
			{
				return false;
			}
			return true;
		}
		
		private bool r_case()
		{
			int among_var;
			int v_1;
			int v_2;
			int v_3;
			int v_4;
			int v_5;
			// (, line 95
			// setlimit, line 96
			v_1 = limit - cursor;
			// tomark, line 96
			if (cursor < I_p1)
			{
				return false;
			}
			cursor = I_p1;
			v_2 = limit_backward;
			limit_backward = cursor;
			cursor = limit - v_1;
			// (, line 96
			// [, line 96
			ket = cursor;
			// substring, line 96
			among_var = find_among_b(a_6, 30);
			if (among_var == 0)
			{
				limit_backward = v_2;
				return false;
			}
			// ], line 96
			bra = cursor;
			limit_backward = v_2;
			switch (among_var)
			{
				
				case 0: 
					return false;
				
				case 1: 
					// (, line 98
					// literal, line 98
					if (!(eq_s_b(1, "a")))
					{
						return false;
					}
					break;
				
				case 2: 
					// (, line 99
					// literal, line 99
					if (!(eq_s_b(1, "e")))
					{
						return false;
					}
					break;
				
				case 3: 
					// (, line 100
					// literal, line 100
					if (!(eq_s_b(1, "i")))
					{
						return false;
					}
					break;
				
				case 4: 
					// (, line 101
					// literal, line 101
					if (!(eq_s_b(1, "o")))
					{
						return false;
					}
					break;
				
				case 5: 
					// (, line 102
					// literal, line 102
					if (!(eq_s_b(1, "\u00E4")))
					{
						return false;
					}
					break;
				
				case 6: 
					// (, line 103
					// literal, line 103
					if (!(eq_s_b(1, "\u00F6")))
					{
						return false;
					}
					break;
				
				case 7: 
					// (, line 111
					// try, line 111
					v_3 = limit - cursor;
					do 
					{
						// (, line 111
						// and, line 113
						v_4 = limit - cursor;
						// or, line 112
						do 
						{
							v_5 = limit - cursor;
							do 
							{
								// call LONG, line 111
								if (!r_LONG())
								{
									goto lab2_brk;
								}
								goto lab1_brk;
							}
							while (false);

lab2_brk: ;
							
							cursor = limit - v_5;
							// literal, line 112
							if (!(eq_s_b(2, "ie")))
							{
								cursor = limit - v_3;
								goto lab0_brk;
							}
						}
						while (false);

lab1_brk: ;
						
						cursor = limit - v_4;
						// next, line 113
						if (cursor <= limit_backward)
						{
							cursor = limit - v_3;
							goto lab0_brk;
						}
						cursor--;
						// ], line 113
						bra = cursor;
					}
					while (false);

lab0_brk: ;
					
					break;
				
				case 8: 
					// (, line 119
					if (!(in_grouping_b(g_v, 97, 246)))
					{
						return false;
					}
					if (!(out_grouping_b(g_v, 97, 246)))
					{
						return false;
					}
					break;
				
				case 9: 
					// (, line 121
					// literal, line 121
					if (!(eq_s_b(1, "e")))
					{
						return false;
					}
					break;
				}
			// delete, line 138
			slice_del();
			// set ending_removed, line 139
			B_ending_removed = true;
			return true;
		}
		
		private bool r_other_endings()
		{
			int among_var;
			int v_1;
			int v_2;
			int v_3;
			// (, line 141
			// setlimit, line 142
			v_1 = limit - cursor;
			// tomark, line 142
			if (cursor < I_p2)
			{
				return false;
			}
			cursor = I_p2;
			v_2 = limit_backward;
			limit_backward = cursor;
			cursor = limit - v_1;
			// (, line 142
			// [, line 142
			ket = cursor;
			// substring, line 142
			among_var = find_among_b(a_7, 14);
			if (among_var == 0)
			{
				limit_backward = v_2;
				return false;
			}
			// ], line 142
			bra = cursor;
			limit_backward = v_2;
			switch (among_var)
			{
				
				case 0: 
					return false;
				
				case 1: 
					// (, line 146
					// not, line 146
					{
						v_3 = limit - cursor;
						do 
						{
							// literal, line 146
							if (!(eq_s_b(2, "po")))
							{
								goto lab4_brk;
							}
							return false;
						}
						while (false);

lab4_brk: ;
						
						cursor = limit - v_3;
					}
					break;
				}
			// delete, line 151
			slice_del();
			return true;
		}
		
		private bool r_i_plural()
		{
			int v_1;
			int v_2;
			// (, line 153
			// setlimit, line 154
			v_1 = limit - cursor;
			// tomark, line 154
			if (cursor < I_p1)
			{
				return false;
			}
			cursor = I_p1;
			v_2 = limit_backward;
			limit_backward = cursor;
			cursor = limit - v_1;
			// (, line 154
			// [, line 154
			ket = cursor;
			// substring, line 154
			if (find_among_b(a_8, 2) == 0)
			{
				limit_backward = v_2;
				return false;
			}
			// ], line 154
			bra = cursor;
			limit_backward = v_2;
			// delete, line 158
			slice_del();
			return true;
		}
		
		private bool r_t_plural()
		{
			int among_var;
			int v_1;
			int v_2;
			int v_3;
			int v_4;
			int v_5;
			int v_6;
			// (, line 160
			// setlimit, line 161
			v_1 = limit - cursor;
			// tomark, line 161
			if (cursor < I_p1)
			{
				return false;
			}
			cursor = I_p1;
			v_2 = limit_backward;
			limit_backward = cursor;
			cursor = limit - v_1;
			// (, line 161
			// [, line 162
			ket = cursor;
			// literal, line 162
			if (!(eq_s_b(1, "t")))
			{
				limit_backward = v_2;
				return false;
			}
			// ], line 162
			bra = cursor;
			// test, line 162
			v_3 = limit - cursor;
			if (!(in_grouping_b(g_v, 97, 246)))
			{
				limit_backward = v_2;
				return false;
			}
			cursor = limit - v_3;
			// delete, line 163
			slice_del();
			limit_backward = v_2;
			// setlimit, line 165
			v_4 = limit - cursor;
			// tomark, line 165
			if (cursor < I_p2)
			{
				return false;
			}
			cursor = I_p2;
			v_5 = limit_backward;
			limit_backward = cursor;
			cursor = limit - v_4;
			// (, line 165
			// [, line 165
			ket = cursor;
			// substring, line 165
			among_var = find_among_b(a_9, 2);
			if (among_var == 0)
			{
				limit_backward = v_5;
				return false;
			}
			// ], line 165
			bra = cursor;
			limit_backward = v_5;
			switch (among_var)
			{
				
				case 0: 
					return false;
				
				case 1: 
					// (, line 167
					// not, line 167
					{
						v_6 = limit - cursor;
						do 
						{
							// literal, line 167
							if (!(eq_s_b(2, "po")))
							{
								goto lab4_brk;
							}
							return false;
						}
						while (false);

lab4_brk: ;
						
						cursor = limit - v_6;
					}
					break;
				}
			// delete, line 170
			slice_del();
			return true;
		}
		
		private bool r_tidy()
		{
			int v_1;
			int v_2;
			int v_3;
			int v_4;
			int v_5;
			int v_6;
			int v_7;
			int v_8;
			int v_9;
			// (, line 172
			// setlimit, line 173
			v_1 = limit - cursor;
			// tomark, line 173
			if (cursor < I_p1)
			{
				return false;
			}
			cursor = I_p1;
			v_2 = limit_backward;
			limit_backward = cursor;
			cursor = limit - v_1;
			// (, line 173
			// do, line 174
			v_3 = limit - cursor;
			do 
			{
				// (, line 174
				// and, line 174
				v_4 = limit - cursor;
				// call LONG, line 174
				if (!r_LONG())
				{
					goto lab0_brk;
				}
				cursor = limit - v_4;
				// (, line 174
				// [, line 174
				ket = cursor;
				// next, line 174
				if (cursor <= limit_backward)
				{
					goto lab0_brk;
				}
				cursor--;
				// ], line 174
				bra = cursor;
				// delete, line 174
				slice_del();
			}
			while (false);

lab0_brk: ;
			
			cursor = limit - v_3;
			// do, line 175
			v_5 = limit - cursor;
			do 
			{
				// (, line 175
				// [, line 175
				ket = cursor;
				if (!(in_grouping_b(g_AEI, 97, 228)))
				{
					goto lab1_brk;
				}
				// ], line 175
				bra = cursor;
				if (!(out_grouping_b(g_v, 97, 246)))
				{
					goto lab1_brk;
				}
				// delete, line 175
				slice_del();
			}
			while (false);

lab1_brk: ;
			
			cursor = limit - v_5;
			// do, line 176
			v_6 = limit - cursor;
			do 
			{
				// (, line 176
				// [, line 176
				ket = cursor;
				// literal, line 176
				if (!(eq_s_b(1, "j")))
				{
					goto lab2_brk;
				}
				// ], line 176
				bra = cursor;
				// or, line 176
				do 
				{
					v_7 = limit - cursor;
					do 
					{
						// literal, line 176
						if (!(eq_s_b(1, "o")))
						{
							goto lab4_brk;
						}
						goto lab3_brk;
					}
					while (false);

lab4_brk: ;
					
					cursor = limit - v_7;
					// literal, line 176
					if (!(eq_s_b(1, "u")))
					{
						goto lab2_brk;
					}
				}
				while (false);

lab3_brk: ;
				
				// delete, line 176
				slice_del();
			}
			while (false);

lab2_brk: ;
			
			cursor = limit - v_6;
			// do, line 177
			v_8 = limit - cursor;
			do 
			{
				// (, line 177
				// [, line 177
				ket = cursor;
				// literal, line 177
				if (!(eq_s_b(1, "o")))
				{
					goto lab5_brk;
				}
				// ], line 177
				bra = cursor;
				// literal, line 177
				if (!(eq_s_b(1, "j")))
				{
					goto lab5_brk;
				}
				// delete, line 177
				slice_del();
			}
			while (false);

lab5_brk: ;
			
			cursor = limit - v_8;
			limit_backward = v_2;
			// goto, line 179
			while (true)
			{
				v_9 = limit - cursor;
				do 
				{
					if (!(out_grouping_b(g_v, 97, 246)))
					{
						goto lab7_brk;
					}
					cursor = limit - v_9;
					goto golab6_brk;
				}
				while (false);

lab7_brk: ;
				
				cursor = limit - v_9;
				if (cursor <= limit_backward)
				{
					return false;
				}
				cursor--;
			}

golab6_brk: ;
			
			// [, line 179
			ket = cursor;
			// next, line 179
			if (cursor <= limit_backward)
			{
				return false;
			}
			cursor--;
			// ], line 179
			bra = cursor;
			// -> x, line 179
			S_x = slice_to(S_x);
			// name x, line 179
			if (!(eq_v_b(S_x)))
			{
				return false;
			}
			// delete, line 179
			slice_del();
			return true;
		}
		
		public virtual bool Stem()
		{
			int v_1;
			int v_2;
			int v_3;
			int v_4;
			int v_5;
			int v_6;
			int v_7;
			int v_8;
			int v_9;
			// (, line 183
			// do, line 185
			v_1 = cursor;
			do 
			{
				// call mark_regions, line 185
				if (!r_mark_regions())
				{
					goto lab0_brk;
				}
			}
			while (false);

lab0_brk: ;
			
			cursor = v_1;
			// unset ending_removed, line 186
			B_ending_removed = false;
			// backwards, line 187
			limit_backward = cursor; cursor = limit;
			// (, line 187
			// do, line 188
			v_2 = limit - cursor;
			do 
			{
				// call particle_etc, line 188
				if (!r_particle_etc())
				{
					goto lab1_brk;
				}
			}
			while (false);

lab1_brk: ;
			
			cursor = limit - v_2;
			// do, line 189
			v_3 = limit - cursor;
			do 
			{
				// call possessive, line 189
				if (!r_possessive())
				{
					goto lab2_brk;
				}
			}
			while (false);

lab2_brk: ;
			
			cursor = limit - v_3;
			// do, line 190
			v_4 = limit - cursor;
			do 
			{
				// call case, line 190
				if (!r_case())
				{
					goto lab3_brk;
				}
			}
			while (false);

lab3_brk: ;
			
			cursor = limit - v_4;
			// do, line 191
			v_5 = limit - cursor;
			do 
			{
				// call other_endings, line 191
				if (!r_other_endings())
				{
					goto lab4_brk;
				}
			}
			while (false);

lab4_brk: ;
			
			cursor = limit - v_5;
			// or, line 192

			do 
			{
				v_6 = limit - cursor;
				do 
				{
					// (, line 192
					// Boolean test ending_removed, line 192
					if (!(B_ending_removed))
					{
						goto lab6_brk;
					}
					// do, line 192
					v_7 = limit - cursor;
					do 
					{
						// call i_plural, line 192
						if (!r_i_plural())
						{
							goto lab7_brk;
						}
					}
					while (false);

lab7_brk: ;
					
					cursor = limit - v_7;
					goto lab6_brk;
				}
				while (false);

lab6_brk: ;
				
				cursor = limit - v_6;
				// do, line 192
				v_8 = limit - cursor;
				do 
				{
					// call t_plural, line 192
					if (!r_t_plural())
					{
						goto lab8_brk;
					}
				}
				while (false);

lab8_brk: ;
				
				cursor = limit - v_8;
			}
			while (false);

lab5_brk: ;

			// do, line 193
			v_9 = limit - cursor;
			do 
			{
				// call tidy, line 193
				if (!r_tidy())
				{
					goto lab9_brk;
				}
			}
			while (false);

lab9_brk: ;
			
			cursor = limit - v_9;
			cursor = limit_backward; return true;
		}
	}
}