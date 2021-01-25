using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak2
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public int UpVoteCount { get; private set; }
        public int DownVoteCount { get; private set; }

        public int CurrentVoteValue 
        {
            get
            {
                return UpVoteCount - DownVoteCount;
            }
        }

        public int UpVote()
        {
            return UpVoteCount++;
        }

        public int DownVote()
        {
            return DownVoteCount++;
        }
    }
}
