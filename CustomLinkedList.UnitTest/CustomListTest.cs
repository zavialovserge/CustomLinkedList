using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
            Node node = new Node(value);
            Node result = _customList.ContainsValue(value);
            Assert.IsNull(result);
        }
        
        //[TestMethod]
        //public void Check_Null_Adiing()
        //{
        //    _customList.Append(null);
        //    Node node = new Node(null);
        //    Node result = _customList.ContainsValue(null);
        //    Assert.AreEqual(node.Value,result.Value);
        //}

        [DataTestMethod]
        [DataRow(new string[] { "Test1", "Test2", "Test3" })]
        [DataRow(new string[] { "1" })]
        [DataRow(new string[] { " ", " ", " " })]
        [DataRow(new string[] { "","",""})]
        [DataRow(new string[] { null, null, null })]

        public void Array_Of_Values_Are_Equal(string[] values)
        {
            _customList = new CustomLinkedList();
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

        [TestMethod]
        public void Check_Decrease_Count_List_After_Delete()
        {
            _customList.DeleteNode("Test1");
            Assert.AreEqual(2, _customList.Count);
        }
        [TestMethod]
        public void Check_Not_Decrease_Count_List_After_Delete_Not_Exist_Value()
        {
            _customList.DeleteNode("Test");
            Assert.AreEqual(3, _customList.Count);
        }
        [DataTestMethod]
        [DataRow("Test1")]
        [DataRow("Test2")]
        [DataRow("Test3")]
        public void Check_Delete_Exist_Value(string value)
        {
            Assert.IsTrue(_customList.DeleteNode(value));
        }
        [DataTestMethod]
        [DataRow("123")]
        [DataRow("Test")]
        [DataRow("")]
        [DataRow(" ")]
        [DataRow(null)]
        public void Check_Delete_Not_Exist_Value(string value)
        {
            Assert.IsFalse(_customList.DeleteNode(value));
        }

        [TestMethod]
        public void Change_Head_To_Next_If_Delete_Head_Value()
        {
            Node head_before_delete = _customList.Head;
            Node nextNode = _customList.Head.Next;

            _customList.DeleteNode(head_before_delete.Value);

            Assert.AreEqual(nextNode.Value,_customList.Head.Value);
        }
        
        [TestMethod]
        public void Change_Tail_If_Delete_Head_Value()
        {
            Node tail_before_delete = _customList.Tail;           

            _customList.DeleteNode(tail_before_delete.Value);

            Assert.AreNotEqual(tail_before_delete.Value, _customList.Tail.Value);
        }


    }
}
