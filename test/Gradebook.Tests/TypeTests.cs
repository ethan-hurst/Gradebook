using System;
using Xunit;

namespace Gradebook.Tests
{
  public class TypeTests
  {
    [Fact]
    public void Test1()
    {
      var x = GetInt();
      SetInt(ref x);

      Assert.Equal(42, x);
    }



    [Fact]
    public void CSharpCanPassByRef()
    {
      var book1 = GetBook("Book1");
      GetBookSetName(out book1, "New Name");

      Assert.Equal("New Name", book1.Name);
    }

    [Fact]
    public void CSharpIsPassByValue()
    {
      var book1 = GetBook("Book1");
      GetBookSetName(book1, "New Name");

      Assert.Equal("Book1", book1.Name);
    }

    [Fact]
    public void CanSetFromReference()
    {
      var book1 = GetBook("Book1");
      SetName(book1, "New Name");

      Assert.Equal("Book1", book1.Name);
    }

    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
      var book1 = GetBook("Book1");
      var book2 = GetBook("Book2");

      Assert.Equal("Book1", book1.Name);
      Assert.Equal("Book2", book2.Name);
      Assert.NotSame(book1, book2);
    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
      var book1 = GetBook("Book1");
      var book2 = book1;

      Assert.Same(book1, book2);
      Assert.True(Object.ReferenceEquals(book1, book2));
    }

    private Book GetBook(string name)
    {
      return new Book(name);
    }
    private void SetName(Book book, string name)
    {
      book.Name = name;
    }
    private void GetBookSetName(Book book, string name)
    {
      book = new Book(name);
      book.Name = name;
    }
    private void GetBookSetName(out Book book, string name)
    {
      book = new Book(name);
      book.Name = name;
    }
    private int GetInt()
    {
      return 3;
    }
    private void SetInt(ref int x)
    {
      x = 42;
    }
  }

}
