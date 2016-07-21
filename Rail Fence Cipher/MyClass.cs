/*
 * Created by SharpDevelop.
 * User: Anne
 * Date: 04/01/2007
 * Time: 17:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
#if DEBUG
using System.Diagnostics;
#endif
using System;
using System.Collections.Generic;

namespace RailFenceCypher
{
	/// <summary>
	/// Encodes stuff into the RailFenceCypher
	/// </summary>
	public static class RailFenceCypher
	{
		/// <summary>
		/// Encodes stuff
		/// </summary>
		/// <param name="input">The string to encode</param>
		/// <returns>Encoding result</returns>
		public static string Encode(string input)
		{
			char[] inputc = input.ToCharArray();
			string pasA = "";
			string pasB = "";
			bool x = true;
			foreach(char ch in inputc)
			{
				if(x == true)
				{
					pasA += ch;
					x = false;
				}
				else
				{
					x = true;
					pasB += ch;
				}
			}
			return pasA + pasB;
		}
		
		/// <summary>
		/// Decodes stuff into plain text
		/// </summary>
		/// <param name="input">The string to decode</param>
		/// <returns>The decoded result</returns>
		public static string DeCode(string input)
		{
				int lnl = (int)Math.Round((decimal)input.Length / 2);
				//Write Strings
				char[] ln1, ln2;
				ln1 = input.Substring(0, lnl).ToCharArray();
				ln2 = input.Substring(lnl).ToCharArray();
				#if DEBUG
				Debug.WriteLine("Line 1: " + input.Substring(0, lnl));
				Debug.WriteLine("Line 2: " + input.Substring(lnl, input.Length - lnl));
				#endif
				//Writen strings, now seperate into one
				bool top = true;
				string output = "";
				int x, topx, botx;
				x = 1; topx = 0; botx = 0;
				while( x != input.Length + 1)
				{
					if(top == true)
					{
						if(topx > ln1.Length - 1)
						{
							return output;
						}
						output += ln1[topx]; topx += 1; top = false;
						#if DEBUG
						Debug.WriteLine("topx: " + topx + " ln1 length: " + ln1.Length);
						#endif
					}
					else
					{
						output += ln2[botx]; botx += 1; top = true;
					}
					x++;
				}
				return output;
			
		}
	}
}
