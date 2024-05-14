namespace Nodes
{
    public class Node
    {
        private int value;
        private List<Node> childrens;

        public Node(int _value)
        {
            value = _value;
            childrens = new List<Node>();
        }

        public void PrintValues()
        {
            Console.WriteLine(value); 

            if (childrens.Count > 0)
            {
                foreach (Node child in childrens)
                {
                    child.PrintValues(); 
                }
            }
        }

        public List<Node> GetChildrens()
        {
            return childrens;
        }
    }
}
