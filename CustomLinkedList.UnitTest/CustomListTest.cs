using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CustomLinkedList.UnitTest
{
    [TestClass]
    public class CustomListTest
    {
        CustomLinkedList _customList;
        [TestInitialize]
        public void SetUp()
        {
            _customList = new CustomLinkedList();
            _customList.Append("Test1");
            _customList.Append("Test2");
            _customList.Append("Test3");
        }


        [TestMethod]
        public void Check_List_Count()
        {            
            Assert.AreEqual(3, _customList.Count);
        }
        [TestMethod]
        public void Check_Head_Value()
        {
            string value = "Test1";
            Assert.AreEqual(value, _customList.Head.Value);
        }

        [TestMethod]
        public void Check_Middle_Value()
        {
            string value = "Test2";
            Assert.AreEqual(value, _customList.Head.Next.Value);
        }
        [TestMethod]
        public void Check_Tail_Next_Null_Value()
        {
            Assert.IsNull(_customList.Tail.Next);
        }

        [TestMethod]
        public void Check_Tail_Value()
        {
            string value = "Test3";
            Assert.AreEqual(value, _customList.Tail.Value);
        }
        
    }
}
