using CitrusByte;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace CitrusByte.Tests
{
    [TestClass()]
    public class FlattenTests
    {
       
        [TestMethod()]
        public void SampleTestSholdBePass()
        {
            // [[1,2,[3]],4] → [1,2,3,4]
            ArrayList test = new ArrayList() { new ArrayList() { 1, 2, new ArrayList() { 3 } } , 4 };

            int[] expectedResult = new int[] { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(expectedResult, FlattenArrayTest.Flatten(test));
        }
        

      
    }
}