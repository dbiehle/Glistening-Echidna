using System;
using System.Collections.Generic;

namespace ReferenceGame
{
	public class Display
	{

		public void Output(string text, 
							ConsoleColor fg = ConsoleColor.White, 
							ConsoleColor bg = ConsoleColor.Black)
		{
			Console.BackgroundColor = bg;
			Console.ForegroundColor = fg;
            Console.Write(text);
			Console.ResetColor();
		}
		
		public string CommandPrompt(string promptText = "~:// ")
		{
			Output(promptText);
			return Console.ReadLine();

		}

		public static List<string> Wrap(string str, int maxWidth, int upperMargin = 1, int lowerMargin = 0)
		{
			List<string> output = new List<string>();
			str = new string(' ', upperMargin) + str;
			string lower = new string(' ', lowerMargin);

            while (str.Length > maxWidth || str.IndexOf("\n") != -1 || str[0] == '\n')
			{
				int lineBreak = str.IndexOf("\n");
                int lastSpace = str.Substring(0, maxWidth).LastIndexOf(" ");
				int space;
				if (lineBreak == 0)
				{
					output.Add("");
					str = new string(' ', upperMargin) + str.Substring(1);
					lastSpace = str.Substring(0, maxWidth).LastIndexOf(" ");
				}
				if (lineBreak > 0 && lineBreak < maxWidth) space = lineBreak;
				else if (lastSpace > upperMargin && lastSpace < maxWidth) space = lastSpace;
				else space = maxWidth - 1;
				output.Add(str.Substring(0, space).PadRight(maxWidth));
				str = str.Substring(space);
				if (space < str.Length && str[0] != '\n') str = new string(' ', lowerMargin) + str;
			}
			output.Add(str.PadRight(maxWidth));
			return output;
		}

	}
}

