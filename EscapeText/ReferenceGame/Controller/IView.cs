// Includes the View interface 

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing;
using Console = Colorful.Console;

namespace ReferenceGame
{

    public interface IView
    {
        Display Display { get; set; }
        ITextBox VisualRep { get; set; }
        ITextBox TBRoomContents { get; set; }
        ITextBox StoryText { get; set; }

        string UpdateScreenAndGetInput();
    }


    public interface ITextBox
    {
        int Width { get; set; }
        int Height { get; set; }
        List<string> ProcessedTextList { get; set; }
        List<String> SourceText { get; set; }
        ConsoleColor TextColor { get; set; }
        ConsoleColor BgColor { get; set; }
        
    }


}