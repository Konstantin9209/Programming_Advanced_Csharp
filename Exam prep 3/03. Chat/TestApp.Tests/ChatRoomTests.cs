using NUnit.Framework;
using TestApp.Chat;

public class ChatRoomTests
{
    private ChatRoom _chatRoom;

    [SetUp]
    public void Setup()
    {
        _chatRoom = new ChatRoom();
    }

    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        _chatRoom.SendMessage("Alice", "Hello, World!");
        var chatContent = _chatRoom.DisplayChat();
        StringAssert.Contains("Alice: Hello, World!", chatContent);
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        var chatContent = _chatRoom.DisplayChat();
        Assert.IsEmpty(chatContent);
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        _chatRoom.SendMessage("Alice", "Hello, World!");
        _chatRoom.SendMessage("Bob", "Hi, Alice!");
        var chatContent = _chatRoom.DisplayChat();

        StringAssert.Contains("Alice: Hello, World!", chatContent);
        StringAssert.Contains("Bob: Hi, Alice!", chatContent);
    }
}
