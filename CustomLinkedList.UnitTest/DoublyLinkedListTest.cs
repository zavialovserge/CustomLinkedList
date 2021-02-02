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
            TwoWayNode head = new TwoWayNode("Test1");
            TwoWayNode middle = new TwoWayNode("Test2");
            TwoWayNode tail = new TwoWayNode("Test3");
            _customList.Head = head;
            _customList.Head.Next = middle;
            _customList.Head.Next.Next = tail;
            _customList.Head.Next.Previous = _customList.Head;
            _customList.Tail = tail;
            _customList.Tail.Previous = _customList.Head.Next;
            _customList.Count = 3;
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
        [TestMethod]
        public void Append_Element_In_Tail()
        {
            TwoWayNode node = new TwoWayNode("Test4");
            _customList.Append(node.Value);
            Assert.AreEqual(_customList.Tail.Value, node.Value);
        }
        [TestMethod]
        public void Append_Element_In_Tail_Check_Count()
        {
            TwoWayNode node = new TwoWayNode("Test4");
            int count = _customList.Count;
            _customList.Append(node.Value);
            Assert.AreEqual(_customList.Count, count+1);
        }
        [TestMethod]
        public void Append_Element_In_Tail_Check_Previous_Element()
        {

            TwoWayNode node = new TwoWayNode("Test4");
            TwoWayNode node_previous = _customList.Tail;
            _customList.Append(node.Value);

            Assert.AreEqual(_customList.Tail.Previous.Value, node_previous.Value);
        }
        [TestMethod]
        public void Append_Element_Check_Next_Element_In_Previous()
        {
            TwoWayNode node = new TwoWayNode("Test4");
            _customList.Append(node.Value);
            var previous_node = _customList.Tail.Previous;
            Assert.AreEqual(previous_node.Next.Value, node.Value);
        }
        [TestMethod]
        public void Append_Element_In_Tail_Check_Next_Element_Is_Null()
        {
            TwoWayNode node = new TwoWayNode("Test4");
            _customList.Append(node.Value);
            Assert.IsNull(_customList.Tail.Next);
        }
        [DataTestMethod]
        [DataRow("Test1")]
        [DataRow("Test2")]
        [DataRow("Test3")]
        public void Check_Value_Exist(string value)
        {
            TwoWayNode node = new TwoWayNode(value);
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

        [TestMethod]
        public void Delete_Element_Count_Decrease()
        {
            int count = _customList.Count;
            _customList.Remove("Test1");
            Assert.AreEqual(count-1,_customList.Count);
        }
        [TestMethod]
        public void Delete_Exist_Element()
        {      
            Assert.IsTrue(_customList.Remove(_customList.Head.Value));

        }
        [TestMethod]
        public void Delete_Not_Exist_Element()
        {
            TwoWayNode NotExistNode = new TwoWayNode("Test");
            Assert.IsFalse(_customList.Remove(NotExistNode.Value));

        }
        [TestMethod]
        public void Delete_Head_Middle_Change_To_Head()
        {
            TwoWayNode node = _customList.Head.Next;
            _customList.Remove(_customList.Head.Value);

            Assert.AreEqual(node.Value, _customList.Head.Value);

        }
       

        [TestMethod]
        public void Delete_Middle_Previous_Next_In_Head_Equal_To_Previous_Tail()
        {
            TwoWayNode node = _customList.Head.Next;
            _customList.Remove(node.Value);

            Assert.AreEqual(_customList.Head.Next.Value, _customList.Tail.Value);

        }
        [TestMethod]
        public void Delete_In_Empty_List()
        {
            TwoWayNode node = _customList.Head;
            _customList.Head = null;
            _customList.Tail = null;
            
            Assert.IsFalse(_customList.Remove(node.Value));


        }
        [TestMethod]
        public void Delete_In_One_Element_List()
        {
            TwoWayNode node = _customList.Head;
            _customList.Head = null;
            _customList.Tail = null;
            _customList.Count = 0;
            _customList.Append("Test1");           
            Assert.IsTrue(_customList.Remove(node.Value));
        }
        [TestMethod]
        public void Check_Count_Delete_In_One_Element_List()
        {
            TwoWayNode node = _customList.Head;
            _customList.Head = null;
            _customList.Tail = null;
            _customList.Count = 0;
            _customList.Append("Test1");
            int count = _customList.Count;
            _customList.Remove(node.Value);
            Assert.AreEqual(count-1,_customList.Count);
        }
        [TestMethod]
        public void Check_Head_Is_Null_In_One_Element_List()
        {
            TwoWayNode node = _customList.Head;
            _customList.Head = null;
            _customList.Tail = null;
            _customList.Count = 0;
            _customList.Append("Test1");
            _customList.Remove(node.Value);
            Assert.IsNull(_customList.Head);
        }
    }
}
