using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Exercises = DEM.DotNet.Algorithm.EntityLinkedList;

namespace DEM.DotNet.Algorithm
{
    public class ExcerciseDataStructureLinkedList
    {
        public void CreateList()
        {
            Exercises.LinkedList myList = new Exercises.LinkedList();
            myList.Add(3);
            myList.Add(5);
            myList.Add(7);
            myList.Add(9);
            myList.Add(11);
            myList.Add(15);

            myList.Traverse();
        }

    }
}
