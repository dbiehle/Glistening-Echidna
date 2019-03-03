// Includes the View boxes and their design

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing;
using Console = Colorful.Console;

namespace ReferenceGame
{

    public enum TextBoxArea
    {
        VisualRepresentation,
        RoomContents,
        StoryText,
        CommandText
    }

    public class View : IView
    {
        public Display Display { get; set; } = new Display();

        public ITextBox VisualRep { get; set; }
        public ITextBox TBRoomContents { get; set; }
        public ITextBox StoryText { get; set; }

        public View(List<string> visRep, List<string> roomContents, List<string> storyText)
        {

            //+-------------------------------+
            //|               |               |
            //| VisualRep     |               |
            //|               |               |
            //|               | TBRoomContents|
            //+---------------+               |
            //|               |               |
            //| StoryText     |               |
            //|               |               |
            //+---------------+---------------+
            //+--------------Command-------- +


            VisualRep = new TextBox(75, 20, visRep,
                                    textColor: ConsoleColor.Black, bgColor: ConsoleColor.White);
            TBRoomContents = new TextBox(25, 32, roomContents,
                                    textColor: ConsoleColor.White, bgColor: ConsoleColor.DarkCyan);
            StoryText = new TextBox(75, 12, storyText,
                                    textColor: ConsoleColor.White, bgColor: ConsoleColor.Black);

        }


        public string UpdateScreenAndGetInput()
        {
            Console.Clear();
            int commandAndTitleHeight = 3;

            int windowWidth = VisualRep.Width + TBRoomContents.Width;
            int windowHeight = TBRoomContents.Height + commandAndTitleHeight;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.WindowWidth = windowWidth;
                Console.WindowHeight = windowHeight;
            }


            for (var i = 0; i < VisualRep.Height; i += 1)
            {
                Display.Output(VisualRep.ProcessedTextList[i], VisualRep.TextColor, VisualRep.BgColor);
                Display.Output(TBRoomContents.ProcessedTextList[i], TBRoomContents.TextColor, TBRoomContents.BgColor);
                Console.WriteLine();
            }

            for (var i = 0; i < StoryText.Height; i += 1)
            {
                Display.Output(StoryText.ProcessedTextList[i], StoryText.TextColor, StoryText.BgColor);
                Display.Output(TBRoomContents.ProcessedTextList[i + VisualRep.Height], TBRoomContents.TextColor, TBRoomContents.BgColor);
                Console.WriteLine();
            }

            return Display.CommandPrompt();

        }
    }



    public class TextBox : ITextBox
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<string> ProcessedTextList { get; set; }
        public List<String> SourceText { get; set; }
        public ConsoleColor TextColor { get; set; }
        public ConsoleColor BgColor { get; set; }

        public TextBox(int width, int height, List<string> wrappedTextList,
                        ConsoleColor textColor, ConsoleColor bgColor)
        {
            var processedText = new List<String>();
            for (var i = 0; i < height; i += 1)
            {
                if (i > wrappedTextList.Count - 1)
                {
                    processedText.Add("".PadRight(width));
                }
                else
                {
                    processedText.Add(wrappedTextList[i].PadRight(width));
                }
            }
            Width = width;
            Height = height;
            ProcessedTextList = processedText;
            SourceText = wrappedTextList;
            TextColor = textColor;
            BgColor = bgColor;
        }
    }
}

