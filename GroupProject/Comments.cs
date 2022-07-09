using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Comments
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public int HRId { get; set; }
        public string CommentText { get; set; }
    }
}
