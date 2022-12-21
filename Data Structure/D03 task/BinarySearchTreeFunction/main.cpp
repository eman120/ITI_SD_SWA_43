#include <iostream>

using namespace std;

class Node
{
public:
    int key;
    Node* pLeft;
    Node* pRight;
};
Node *pTree = nullptr;

Node* SearchTree (Node*pRoot, int key)
{
    if (pRoot!=nullptr)
    {
        if (pRoot->key==key) ///Found
            return pRoot;

        else if (pRoot-> key > key )     ///go left
        {
            return SearchTree (pRoot->pLeft,key);

        }
        else                           ///go right
        {
            return SearchTree (pRoot->pRight,key);
        }
    }
    return nullptr;
}

int CountNodes (Node*pRoot)
{
    if (pRoot!= nullptr)
    {
        return CountNodes (pRoot->pLeft)+1+CountNodes (pRoot->pRight);
    }
    return 0;
}

void TreeTraverse (Node*pRoot)
{
    if (pRoot!=nullptr)
    {
        TreeTraverse(pRoot->pLeft);           ///left side

        cout<<pRoot->key<<endl;             ///the root

        TreeTraverse(pRoot->pRight);          ///right side
    }
}


Node*NewNode()
{
    Node*New=new Node();
    if (New==nullptr)
    {
        exit(0);  ///if there is no memory
    }
    New->pLeft = New->pRight=nullptr;
    cout<<"enter new key : "<<endl;
    cin>>New->key;
    return New;
}

///inserting using pass by reference
void InsertNode (Node* &pRoot , Node*New)
{
    if (pRoot==nullptr)
    {
        pRoot=New;
    }

    else if (pRoot->key > New->key)      ///go left
    {
        InsertNode(pRoot->pLeft,New);
    }
    else                          ///go right
    {
        InsertNode(pRoot->pRight,New);
    }
}

///inserting using pointers
void InsertNodeP (Node*pRoot, Node*leaf, Node*New)
{
    if (leaf==nullptr)
    {
        if (pRoot==nullptr)       ///tree is empty
        {
            pTree = New;
        }
        else
        {
            if (pRoot->key>New->key)   ///Add to the left
            {
                pRoot->pLeft=New;
            }
            else           ///add to the right
            {
                pRoot->pRight =New;
            }
        }
    }
    else if (New->key<leaf->key)     ///to left
    {
        InsertNodeP(leaf,leaf->pLeft,New);
    }

    else                           ///to right
    {
        InsertNodeP(leaf,leaf->pRight,New);
    }
}

///Insertion
void InsertNode (Node* &pRoot , Node*New)
{
    if (pRoot==nullptr)
    {
        pRoot=New;
    }

    else if (pRoot->key > New->key)      ///go left
    {
        InsertNode(pRoot->pLeft,New);
    }
    else                          ///go right
    {
        InsertNode(pRoot->pRight,New);
    }
}

void DeleteNode (Node* &pRoot);
int GetMax (Node *pRoot);

void Delete (Node* &pRoot , int key)
{
    if(key < pRoot->key)
    {
        Delete(pRoot->pLeft , key);
    }
    else if (key > pRoot->key)
    {
         Delete(pRoot->pRight , key);
    }
    else ///found
    {
        DeleteNode(pRoot);
    }
}

void DeleteNode (Node* &pRoot)
{
  Node* pDelete = pRoot;

  ///if leaf or node with single child
  if (pRoot->pLeft == nullptr)
  {
      pRoot = pRoot->pRight;
      delete pDelete;
  }
  else if (pRoot->pRight == nullptr)
  {
      pRoot = pRoot->pLeft;
      delete pDelete;
  }
  else ///Delete Root Node
  {
      ///Can't Directly Delete Node with 2 childs
      ///1. Search for Most Right on Left sub Tree (High from Lowest sub tree)
      ///2. SWAP pRoot , Node from Step 1
      ///3. Apply DeleteNode on Swapped Node

      int TempKey = GetMax (pRoot->pLeft); ///Get Max in Left sub tree
      pRoot->key = TempKey;
      Delete(pRoot->pLeft , TempKey); ///Delete Redundant key from Left subTree
  }
}

int GetMax (Node *pRoot)
{
    while (pRoot-> pRight != nullptr)
    {
        pRoot = pRoot->pRight;
    }
    return pRoot->key;
}

int main()
{
    for(int i =0 ; i < 8 ; i++)
    {
        InsertNode(pTree ,NewNode());
    }
    cout<<"Tree : "<<endl;
    TreeTraverse(pTree);

    cout<<"Tree : "<<endl;
    Delete (pTree , 8);
    TreeTraverse(pTree);

    cout<<"Tree : "<<endl;
    Delete (pTree , 2);
    TreeTraverse(pTree);

    cout<<"Tree : "<<endl;
    Delete (pTree , 5);
    TreeTraverse(pTree);

    cout <<"Nodes Count : " <<CountNodes(pTree)<<endl;

    Node* pSearch = SearchTree(pTree , 10);
    if(pSearch != nullptr)
    {
        cout<<"Found \n";
    }
    else
    {
        cout<<"Not Found \n";
    }

    /*
    int Arr[8] = {1, 3, 4, 5, 8, 12, 20, 23};

    cout << "Recursive : " << endl;
    cout << "-----------------" << endl;
    cout << BinarySearch(Arr, 0, 7, 1) << endl;
    cout << BinarySearch(Arr, 0, 7, 5) << endl;
    cout << BinarySearch(Arr, 0, 7, 20) << endl;
    cout << BinarySearch(Arr, 0, 7, 9) << endl;

    cout << endl;
    cout << "===================" << endl;
    cout << endl;

    cout << "Iterative : " << endl;
    cout << "------------------" << endl;
    cout << BinarySearch(Arr, 8, 1) << endl;
    cout << BinarySearch(Arr, 8, 5) << endl;
    cout << BinarySearch(Arr, 8, 20) << endl;
    cout << BinarySearch(Arr, 8, 9) << endl;
    */
    return 0;
}
