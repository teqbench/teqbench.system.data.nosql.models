using Moq;

namespace TeqBench.System.Data.NoSql.Models.Tests;

[TestClass]
public class IDocumentTests
{
    [TestMethod]
    public void TestPropertyStringDefaults()
    {
        var mock = new Mock<IDocument<string>>();

        IDocument<string> doc = mock.Object;
        Assert.IsNull(doc.Id);
        Assert.AreEqual(doc.CreatedAt, DateTime.MinValue);
    }

    [TestMethod]
    public void TestPropertyIntDefaults()
    {
        var mock = new Mock<IDocument<int>>();

        IDocument<int> doc = mock.Object;
        Assert.AreEqual(doc.Id, 0);
        Assert.AreEqual(doc.CreatedAt, DateTime.MinValue);
    }

    [TestMethod]
    public void TestIdAssignment()
    {
        var mock = new Mock<IDocument<string>>();
        mock.SetupProperty(doc => doc.Id);

        IDocument<string> doc = mock.Object;
        doc.Id = "a doc ID";
        Assert.AreEqual(doc.Id, "a doc ID");
    }
}
