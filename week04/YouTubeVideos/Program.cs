using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

      Video video = new Video();
      video._title = "Coding with Sam";
      video._author = "Thomas Sam";
      video._length = 120;

      Video video1 = new Video();
      video1._title = "Tech Innovations";
      video1._author = "Henry Leo";
      video1._length =  40;
    
      Video video2 = new Video();
      video2._title = "Cryptography";
      video2._author = "Sid Newman";
      video2._length = 180;

      Video video3 = new Video();
      video3._title = "Python Classes";
      video3._author = "Tim Harry";
      video3._length = 2400;
    
      List<Video> videos = new List<Video>();
      videos.Add(video);
      videos.Add(video1);
      videos.Add(video2);
      videos.Add(video3);


      for(int i = 0; i < videos.Count; i++)
      {
        if (i == 0)
        {
          videos[i].AddComment("Peter Matthew", " I Learnt a lot, Thanks."); 
          videos[i].AddComment("Thomas Jake", "I would like you to do another video on functions.");
          videos[i].AddComment("Tom Harris", "Your video was very helpful");
          videos[i].AddComment("Friday Newman", "This video makes progrmming fun."); 
        }
        if (i == 1)
        {
          videos[i].AddComment("Sarah Johnson", "Amazing explanation of future technologies!");
          videos[i].AddComment("Michael Brown", "I enjoyed learning about the latest innovations.");
          videos[i].AddComment("Grace Williams", "Very informative and easy to understand.");
          videos[i].AddComment("Daniel Smith", "Looking forward to more tech-related videos.");
        }
        if (i == 2)
        {
          videos[i].AddComment("Alice Cooper", "The encryption concepts were explained clearly.");
          videos[i].AddComment("James Wilson", "This helped me understand cryptography better.");
          videos[i].AddComment("Emma Davis", "Great introduction to cybersecurity topics.");
          videos[i].AddComment("Noah Taylor", "Please make a follow-up video on hashing algorithms.");
        }
        if (i == 3)
        {
          videos[i].AddComment("Olivia Martinez", "Excellent explanation of classes and objects!");
          videos[i].AddComment("Ethan Clark", "The examples made the concepts easy to follow.");
          videos[i].AddComment("Sophia Lewis", "This video helped me with my Python assignment.");
          videos[i].AddComment("Benjamin Hall", "Could you create another video about inheritance?");
        }
      }
      foreach(Video currentVideo in videos)
      {
        int numberComments = currentVideo.NumberOfComments();
        string aboutVideo = currentVideo.DisplayDetails();
        
        Console.WriteLine(aboutVideo);
        Console.WriteLine($"{numberComments} comments");
        video.DisplayComment();
        Console.WriteLine();
      }
    }
}