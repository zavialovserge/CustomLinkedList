using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomLinkedList.UnitTest
{
    class DoublyLinkedListTest
    {
        DoublyLinkedList _customList;
        [TestInitialize]
        public void SetUp()
        {
            _customList = new DoublyLinkedList();
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
        public void Check_Next_After_Head_Is_Middle_Value()
        {
            string value = "Test2";
            Assert.AreEqual(value, _customList.Head.Next.Value);
        }

        [TestMethod]
        public void Check_Previous_Middle_Is_Head_Value()
        {            
            Assert.AreEqual(_customList.Head.Value, _customList.Head.Previous.Value);
        }
        [TestMethod]
        public void Check_Head_Previous_Null_Value()
        {
            Assert.IsNull(_customList.Tail.Previous);
        }
        [TestMethod]
        public void Check_Tail_Next_Null_Value()
        {
            Assert.IsNull(_customList.Tail.Next);
        }


    }
}
