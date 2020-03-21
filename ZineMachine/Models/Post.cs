using System;

namespace ZineMachine.Models
{
    public class Post {     
        public int ZineId {get;set;}
        public int PostId {get;set;}
        public string PostType {get; set;}
        public string TextContent {get; set;}
        public string ContentSource { get; set; }
        public DateTime TimeCreated {get;set;}
        public virtual Zine Zine {get;set;}
    }
}