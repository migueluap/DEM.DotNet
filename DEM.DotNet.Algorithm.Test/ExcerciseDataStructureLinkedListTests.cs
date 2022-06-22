using NUnit.Framework;

namespace DEM.DotNet.Algorithm.Test
{
    public class ExcerciseDataStructureLinkedListTests
    {
        private ExcerciseDataStructureLinkedList? _excerciseDataStructureLinkedList { get; set; }
        
        [SetUp]
        public void Setup()
        {
            _excerciseDataStructureLinkedList = new ExcerciseDataStructureLinkedList();
        }

        [Test]
        public void CreateList_Test()
        {   //Assign
            //var positionNumber = 6;
            //Act
            _excerciseDataStructureLinkedList?.CreateList();
            //Assert
            //Assert.AreEqual(13, fibonacciNumber);

        }



    }
}
