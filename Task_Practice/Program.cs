using Task_Practice;

//////////////////////////////////////////////////////////
var postA = new Post(Guid.Parse("092D9252-34BF-4E68-BE97-8B714A5DC3A4"),"First", "A");
var postB = new Post(Guid.Parse("1949ACA1-2FA2-474C-A967-5910EE08BC70"), "Second", "B");

var superPostA = new List<Post> {postA, postB};

/////////////////////////////////////////////////////////
var postC = new Post(Guid.Parse("092D9252-34BF-4E68-BE97-8B714A5DC3A4"),"Third", "B");
var postD = new Post(Guid.Parse("1949ACA1-2FD2-474C-A967-5910EE08BC70"), "Fourth", "D");

var superPostB = new List<Post> { postC, postD };



var intersectedTopic = superPostA.ZipIntersectBy(superPostB, post => post.Id);

foreach (var (previous, updatedTopic) in intersectedTopic)
{
    Console.WriteLine($"Post eski qiymatlari - {previous.Id} => {previous.Topic} - {previous.Title}");
    Console.WriteLine($"Post yangi qiymatlari - {updatedTopic.Id} => {updatedTopic.Topic} - {updatedTopic.Title}");
}