using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GenericRepoExample.RepoPattern
{
   public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectSate { get; set; }
    }

    public enum ObjectState
    {
        Added,
        Deleted,
        Detached,
        Modified,
        Unchanged
    }
}
