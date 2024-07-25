using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entregable_04.Models;

namespace entregable_04.Interfaces
{
    public interface ISubject
    {
        Guid Id { get; }
        string Name { get; }
        List<Teacher> Teachers { get;}
    }
}