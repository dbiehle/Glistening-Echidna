using System;
using System.Collections.Generic;
using System.Text;
using ReferenceGame;

namespace EscapeRoom_Tests
{
    public class DummyView : IView
    {
        public Display Display { get; set; }
        public ITextBox VisualRep { get; set; }
        public ITextBox TBRoomContents { get; set; }
        public ITextBox StoryText { get; set; }

        public string UpdateScreenAndGetInput()
        {
            return "";
        }
    }
}
