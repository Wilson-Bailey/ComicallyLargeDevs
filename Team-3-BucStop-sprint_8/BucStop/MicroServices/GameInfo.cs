﻿namespace BucStop
{
    public class GameInfo
    {
        public string Content { get; set; }
        public string Title {  get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string DateAdded { get; set; }
        public string HowTo { get; set; }
        public Stack<KeyValuePair<string, int>> LeaderBoard { get; set; }
    }
}
