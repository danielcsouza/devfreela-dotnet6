using System;
using System.Collections.Generic;
using System.Text;

namespace DevFreela.Core.Exceptions
{
    public class ProjectAlreadyStartedException : Exception
    {
        public ProjectAlreadyStartedException() : base("Este projeto já foi iniciado")
        {
        }
    }
}
