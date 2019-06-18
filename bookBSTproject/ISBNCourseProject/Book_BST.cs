using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBNCourseProject
{
    class Book_BST
    {
        protected BookNode treeTop;
        protected class BookNode
        {
            public Book myBook;
            public BookNode LeftNode;
            public BookNode RightNode;

            public BookNode(Book key)
            {
                myBook = key;
            }

            //looks for the next place available to put a new value
            public void AddRec_BookNode(Book keyParam)
            {
                if(keyParam.ISBN == this.myBook.ISBN)
                {
                    throw new ApplicationException("Tried to add duplicate book");
                }
                if(keyParam.ISBN < this.myBook.ISBN)
                {
                    if (this.LeftNode == null)
                    {
                        BookNode newBookNode = new BookNode(keyParam);
                        this.LeftNode = newBookNode;
                        return;
                    }
                    else
                    {
                        this.LeftNode.AddRec_BookNode(keyParam);
                        return;
                    }
                }
                else
                {
                    if(this.RightNode == null)
                    {
                        BookNode newBookNode = new BookNode(keyParam);
                        this.RightNode = newBookNode;
                        return;
                    }
                    else
                    {
                        this.RightNode.AddRec_BookNode(keyParam);
                        return;
                    }
                }
            } // end AddRec

            public Book FindRec_BookNode(Book target)
            {
                BookNode current = this;

                if(target.ISBN == current.myBook.ISBN)
                {
                    return current.myBook;
                }
                else if (target.ISBN > current.myBook.ISBN)
                {
                    if(current.RightNode == null)
                    {
                        throw new ApplicationException("no such ISBN");
                    }
                    else
                    {
                        current = current.RightNode;
                        return current.FindRec_BookNode(target);
                    }
                }
                else
                {
                    if (current.LeftNode == null)
                    {
                        throw new ApplicationException("no such ISBN");
                    }
                    else
                    {
                        current = current.LeftNode;
                        return current.FindRec_BookNode(target);
                    }
                }
            } // end FindRec_BookNode
        } // end BookNode class def

        public void AddRec(Book keyParam)
        {
            if(treeTop == null)
            {
                treeTop = new BookNode(keyParam);
                return;
            }
            else
            {
                treeTop.AddRec_BookNode(keyParam);
            }
        }

        public Book FindRec(int target)
        {
            Book tempBook = new Book();
            tempBook.ISBN = target;
            if(treeTop == null)
            {
                throw new ApplicationException("no such ISBN");
            }
            else
            {
                return treeTop.FindRec_BookNode(tempBook);
            }
        }

        public void Remove(int keyParam)
        {
            if(treeTop == null)
            {
                throw new ApplicationException("Data structure is empty");
            }

            BookNode parentNode = treeTop;
            BookNode childNode;

            bool CameFromParentsLeftPointer = false;

            if (parentNode.myBook.ISBN == keyParam)
            {
                if (parentNode.LeftNode == null && parentNode.RightNode == null)
                {
                    treeTop = null;
                    return;
                }
                if (parentNode.LeftNode != null && parentNode.RightNode == null)
                {
                    treeTop = parentNode.LeftNode;
                    return;
                }
                if (parentNode.RightNode != null && parentNode.LeftNode == null)
                {
                    treeTop = parentNode.RightNode;
                    return;
                }

                BookNode NodeWithKeyValueToOverWrite = parentNode;
                childNode = parentNode.LeftNode;

                CameFromParentsLeftPointer = true;

                while (childNode.RightNode != null)
                {
                    CameFromParentsLeftPointer = false;
                    parentNode = childNode;
                    childNode = parentNode.RightNode;
                }

                if (childNode.LeftNode == null)
                {
                    if (CameFromParentsLeftPointer)
                    {
                        parentNode.LeftNode = null;
                    }
                    else
                    {
                        parentNode.RightNode = null;
                    }

                    NodeWithKeyValueToOverWrite.myBook = childNode.myBook;
                }
                else
                {
                    if(CameFromParentsLeftPointer)
                    {
                        parentNode.LeftNode = childNode.LeftNode;
                    }
                    else
                    {
                        parentNode.RightNode = childNode.LeftNode;
                    }

                    NodeWithKeyValueToOverWrite.myBook = childNode.myBook;
                }
                return;
            }
            while(true)
            {
                if(keyParam < parentNode.myBook.ISBN)
                {
                    if(parentNode.LeftNode == null)
                    {
                        throw new ApplicationException("No such node exists");
                    }
                    childNode = parentNode.LeftNode;
                    CameFromParentsLeftPointer = true;
                }
                else
                {
                    if(parentNode.RightNode == null)
                    {
                        throw new ApplicationException("No such node exists");
                    }
                    childNode = parentNode.RightNode;
                    CameFromParentsLeftPointer = false;
                }
                if (keyParam == childNode.myBook.ISBN)
                {
                    if (childNode.LeftNode == null && childNode.RightNode == null)
                    {
                        if(CameFromParentsLeftPointer)
                        {
                            parentNode.LeftNode = null;
                        }
                        else
                        {
                            parentNode.RightNode = null;
                        }
                        return;
                    }
                    if (childNode.LeftNode != null && childNode.RightNode == null)
                    {
                        if (CameFromParentsLeftPointer)
                        {
                            parentNode.LeftNode = childNode.LeftNode;
                        }
                        else
                        {
                            parentNode.RightNode = childNode.LeftNode;
                        }
                        return;
                    }
                    if (childNode.RightNode != null && childNode.LeftNode == null)
                    {
                        if(CameFromParentsLeftPointer)
                        {
                            parentNode.LeftNode = childNode.RightNode;
                        }
                        else
                        {
                            parentNode.RightNode = childNode.RightNode;
                        }
                        return;
                    }

                    BookNode NodeWithValueToOverWrite = childNode;
                    parentNode = childNode;

                    childNode = parentNode.LeftNode;
                    CameFromParentsLeftPointer = true;
                    while (childNode.RightNode != null)
                    {
                        parentNode = childNode;
                        childNode = parentNode.RightNode;
                        CameFromParentsLeftPointer = false;
                    }

                    if (childNode.LeftNode == null)
                    {
                        if (CameFromParentsLeftPointer)
                        {
                            parentNode.LeftNode = null;
                        }
                        else
                        {
                            parentNode.RightNode = null;
                        }
                        NodeWithValueToOverWrite.myBook = childNode.myBook;
                    }
                    else
                    {
                        if (CameFromParentsLeftPointer)
                        {
                            parentNode.LeftNode = childNode.LeftNode;
                        }
                        else
                        {
                            parentNode.RightNode = childNode.LeftNode;
                        }

                        NodeWithValueToOverWrite.myBook = childNode.myBook;
                    }

                    return;
                }
                else
                {
                    parentNode = childNode;
                }
            }
        }

        public List<ISBNclass> GetISBN()
        {
            List<ISBNclass> newList = new List<ISBNclass>();
            AddISBN(newList, treeTop);
            return newList;
        }

        private void AddISBN(List<ISBNclass> list, BookNode current)
        {
            ISBNclass temp = new ISBNclass();
            if (current == null)
            {
                return;
            }
            AddISBN(list, current.LeftNode);
            temp.ISBN = current.myBook.ISBN;
            list.Add(temp);
            AddISBN(list, current.RightNode);
        }

    }
}
