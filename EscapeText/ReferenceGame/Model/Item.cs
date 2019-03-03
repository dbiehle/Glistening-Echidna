// Item class

using System;
using System.Collections.Generic;

namespace ReferenceGame
{
    public class Item
    {
        public string LongName = "";
        public string CompactName;
        public bool BeenUsed = false;

        public Dictionary<string, string> ItemActionMessages = new Dictionary<string, string>();

        public string Examine()
        {
            return ItemActionMessages["examine"];
        }

        public virtual string Use(GarageRoom room)
        {
            if (BeenUsed)
                return $"Sorry, {LongName} has already been used.";
            else
                BeenUsed = true;

            return ItemActionMessages["use"];
        }

    }

}
