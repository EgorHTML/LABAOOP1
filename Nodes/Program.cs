using Nodes;

Node node = new Node(1);

node.GetChildrens().Add(new Node(2));
node.GetChildrens().Add(new Node(3));

node.GetChildrens()[1].GetChildrens().Add(new Node(8));
node.GetChildrens()[1].GetChildrens().Add(new Node(9));

node.GetChildrens()[0].GetChildrens().Add(new Node(4));
node.GetChildrens()[0].GetChildrens().Add(new Node(5));

node.PrintValues();