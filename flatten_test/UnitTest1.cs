using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NWEA;



namespace flatten_test
{
    [TestClass]
    public class UnitTest1
    {
        public void performTests(Program.NestedInteger inputValue, List<int> expectedAnswer, int testNumber)
        {
            
            List<int> actualAnswer = new List<int>();
            actualAnswer = Program.flatten(inputValue);
            Assert.AreEqual(expectedAnswer.Count(), actualAnswer.Count(), "Test number " + testNumber + ": Answer has wrong number of items in list");
            for (int i = 0; i < expectedAnswer.Count(); i++)
            {
                Assert.AreEqual(expectedAnswer[i], actualAnswer[i], "Test number " + testNumber + ": Values in row: " + i + " don't match.");
            }
        }
        
        
        [TestMethod]
        public void Testflatten()
        {
            //Setting up
            //First, make a bunch of Nested Integers with an integer value.
            Program.NestedInteger nestedInteger0 = new Program.NestedInteger(0);
            Program.NestedInteger nestedInteger1 = new Program.NestedInteger(1);
            Program.NestedInteger nestedInteger2 = new Program.NestedInteger(2);
            Program.NestedInteger nestedInteger3 = new Program.NestedInteger(3);
            Program.NestedInteger nestedInteger4 = new Program.NestedInteger(4);
            Program.NestedInteger nestedInteger5 = new Program.NestedInteger(5);
            Program.NestedInteger nestedInteger6 = new Program.NestedInteger(6);
            Program.NestedInteger nestedInteger7 = new Program.NestedInteger(7);
            Program.NestedInteger nestedInteger8 = new Program.NestedInteger(8);
            Program.NestedInteger nestedInteger9 = new Program.NestedInteger(9);
            Program.NestedInteger nestedInteger10 = new Program.NestedInteger(10);
            Program.NestedInteger nestedInteger11 = new Program.NestedInteger(11);
            Program.NestedInteger nestedInteger12 = new Program.NestedInteger(12);
            Program.NestedInteger nestedInteger13 = new Program.NestedInteger(13);
            Program.NestedInteger nestedInteger14 = new Program.NestedInteger(14);
            Program.NestedInteger nestedInteger15 = new Program.NestedInteger(15);
            Program.NestedInteger nestedInteger16 = new Program.NestedInteger(16);
            Program.NestedInteger nestedInteger17 = new Program.NestedInteger(17);
            Program.NestedInteger nestedInteger18 = new Program.NestedInteger(18);
            Program.NestedInteger nestedInteger19 = new Program.NestedInteger(19);
            Program.NestedInteger nestedIntegerNeg1 = new Program.NestedInteger(-1);
            Program.NestedInteger nestedIntegerNeg2 = new Program.NestedInteger(-2);
            Program.NestedInteger nestedIntegerNeg3 = new Program.NestedInteger(-3);

            //Second, start building lists of integers
            //building [3, 4, 5]
            Program.NestedInteger nestedInteger20 = new Program.NestedInteger();
            nestedInteger20.add(nestedInteger3);
            nestedInteger20.add(nestedInteger4);
            nestedInteger20.add(nestedInteger5);

            //building [7, 8, 9, 10]
            Program.NestedInteger nestedInteger21 = new Program.NestedInteger();
            nestedInteger21.add(nestedInteger7);
            nestedInteger21.add(nestedInteger8);
            nestedInteger21.add(nestedInteger9);
            nestedInteger21.add(nestedInteger10);

            //Third, combine integers and lists of integers to make Nested lists
            //building [12, [7, 8, 9, 10], 13, 14]
            Program.NestedInteger nestedInteger22 = new Program.NestedInteger();
            nestedInteger22.add(nestedInteger12);
            nestedInteger22.add(nestedInteger21);
            nestedInteger22.add(nestedInteger13);
            nestedInteger22.add(nestedInteger14);

            //I forgot about 0 and negative numbers.  Lets make a list of those
            Program.NestedInteger nestedInteger23 = new Program.NestedInteger();
            nestedInteger23.add(nestedIntegerNeg1);
            nestedInteger23.add(nestedInteger0);
            nestedInteger23.add(nestedIntegerNeg3);
            nestedInteger23.add(nestedIntegerNeg2);

            //building [1, 2, [3, 4, 5], 6, [12, [7, 8, 9, 10], 13, 14], 15];
            Program.NestedInteger nestedList = new Program.NestedInteger();
            nestedList.add(nestedInteger1);
            nestedList.add(nestedInteger2);
            nestedList.add(nestedInteger20);
            nestedList.add(nestedInteger6);
            nestedList.add(nestedInteger22);
            nestedList.add(nestedInteger15);



            //Lastly, start running tests with nested lists build above

            //Test 1 - send an empty list
            Program.NestedInteger emptyList = new Program.NestedInteger();
            performTests(emptyList, new List<int>() { }, 1);
            

            //Test 2 - send a list with only integers
            performTests(nestedInteger20, new List<int>() { 3, 4, 5 } , 2);

            //Test 3 - send a list with only one integer
            performTests(nestedInteger3, new List<int>() { 3 }, 3);

            //Test 4 - send a list with negative numbers and 0
            performTests(nestedInteger23, new List<int>() { -1, 0, -3, -2} ,4);


            //Test 5 - send a list, multiple levels of nested links
            performTests(nestedList, new List<int>() { 1, 2, 3, 4, 5, 6, 12, 7, 8, 9, 10, 13, 14, 15 }, 5);
        }
    }
}