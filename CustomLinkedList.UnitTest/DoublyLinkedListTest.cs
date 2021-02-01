using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CustomLinkedList.UnitTest
{
    [TestClass]
    public class DoublyLinkedListTest
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
            Assert.AreEqual(_customList.Head.Value, _customList.Head.Next.Previous.Value);
        }
        [TestMethod]
        public void Check_Head_Previous_Null_Value()
        {
            Assert.IsNull(_customList.Head.Previous);
        }
        [TestMethod]
        public void Check_Tail_Next_Null_Value()
        {
            Assert.IsNull(_customList.Tail.Next);
        }

        [DataTestMethod]
        [DataRow("Test1")]
        [DataRow("Test2")]
        [DataRow("Test3")]
        public void Check_Value_Exist(string value)
        {
            Node node = new Node(value);
            var result = _customList.ContainsValue(value);
            Assert.AreEqual(node.Value, result.Value);
        }
        [DataTestMethod]
        [DataRow("TEst1")]
        [DataRow("")]
        [DataRow(null)]
        [DataRow("Test")]
        public void Check_Value_Not_Exist(string value)
        {
            TwoWayNode node = new TwoWayNode(value);
            TwoWayNode result = _customList.ContainsValue(value);
            Assert.IsNull(result);
        }

        [DataTestMethod]
        [DataRow(new string[] { "Test1", "Test2", "Test3" })]
        [DataRow(new string[] { "1" })]
        [DataRow(new string[] { " ", " ", " " })]
        [DataRow(new string[] { "", "", "" })]
        [DataRow(new string[] { null, null, null })]

        public void Array_Of_Values_Are_Equal(string[] values)
        {
            _customList = new DoublyLinkedList();
            foreach (var value in values)
            {
                _customList.Append(value);
            }

            Assert.IsTrue(Enumerable.SequenceEqual(values, _customList.GetAllValues()));
        }
        [DataTestMethod]
        [DataRow(new string[] { "Test3", "Test2", "Test1" })]
        [DataRow(new string[] { "1" })]
        [DataRow(new string[] { " ", " ", " " })]
        [DataRow(new string[] { "", "", "" })]
        [DataRow(new string[] { null, null, null })]

        public void Array_Of_Values_Are_Not_Equal(string[] values)
        {
            Assert.IsFalse(Enumerable.SequenceEqual(values, _customList.GetAllValues()));
        }


    }
}
