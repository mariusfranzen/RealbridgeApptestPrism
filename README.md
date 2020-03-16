# RealbridgeApptestPrism
An app made with Xamarin.forms, following the MVVM architecture and using Prism.

This is the first time I've tried calling API's and such, so in the first commits there's alot of faulty code and experimentaion. It's also the first time I've used prism.

## Workflow and commits:
1. Add .gitignore and .gitattributes.
    - Basic setup
    
2. Add project files.
    - Basic setup
    
3. Updated NuGet packages
    - Basic setup
    
##### new branch dev
##### new branch feature/basic-api-display

4. Added basic model for radio channels
    - Here i added a model that contained the properties that i was thinking that i wanted to retrieve. At this point i knew just about nothing about API's, and i haven't used JSON in C# before this either, so the model was not very well structured and i ended up changing it multiple times.
    - In the viewmodel i added a public property that i bound to a `CollectionView` on the mainpage.
    
5. Updated MainPageModel.cs
    - Updated the model again. Still not correct.
    
6. Added CollectionView for radio channels
    - Extended the `CollectionView` on the mainpage, preparing it for the API information. I ended up changing this later.
    - Added the `EventToCommandBehavior` from prism in order to bind the `ItemTapped` event to a command instead of using code-behind.
    
7. Modified MainPageModel.cs to match API
    - This is when i finally understood how calling API's worked, and how to make a C# class work with JSON. So I fixed the model to match the API called from http://api.sr.se/api/v2/channels?format=json and http://api.sr.se/api/v2/playlists/rightnow?format=json&channelid=
    - All public properties return a value from a corresponding private field.
    - When setting a property it calls the `SetProperty(ref field, value);` command innherited from `BindableBase` from Prism. This function checks if it needs to alert the subscribers to the property, and does so when needed.
    - In a later commit I moved a big chunk of code that matched the API from http://api.sr.se/api/v2/playlists/rightnow?format=json&channelid= into another model to preserve readabilty, maintainability and to properly follow MVVM.
    
8. The channels are now properly displayed
    - I should definitively have seperated this commit into several commits. 964 additions and 757 deletions in one commit is not that good...
    - I added the ApiClient class that handles the API calls. `GetChannels()` returns a list of all the channels that the API gives you. First it adds the JSON to a `RadioChannel.Channels.RootObject`, and then returns `RadioChannel.Channels.RootObject.channels`, which is a List.
    - `GetPlaylists()` does not return a List, but just a playlist object. Since this API call needs each individual channels ID in order to return that channels playlist, this API gets called alot. I will look into improving this later.
    - I seperated the previous `MainPageModel` into `RadioChannelModel` and `RadioMusicModel`. `RadioChannelModel` handles the `GetChannels` list, and `RadioMusicModel` handles the `GetPlaylists` objects.
    - Now, the main page does not need all the info these API's retrieve. It needs a few bits of both API's. So i created a third model called `RelevantRadioModel` that contains only the things i will be using, and it contains things from both API's.
    - Please ignore the debug `Console.WriteLine()`'s that i forgot to remove before commiting.
    - Added a couple of private fields that some other properties uses.
    - I added an `ObservableCollection` that contains a list of the information from `RelevantRadioModel`.
    - Added the Refresh command, and ItemTapped command.
    - `RefreshList()` is called on startup, and can be manually called by the user. It start by retrieving all channels from the API, then it loops through each channel to get its ID and calls the second API to retrieve the channels playlist. It then proceeds to match Playlist ID's with Channel ID's in a nested foreach loop. Then it adds it to the Radio property that is bound to the CollectionView.
    
9. Final touches
    - Removed some debug messenges and such. Nothing interesting happening here

##### 10. Merge branch 'feature/basic-api-display' into dev

11, 12. Create, Update Readme.md
        - This is where i made this Readme
   
##### new branch feature/general-code-improvement

13. Refined MainPageViewModel.cs
        - Fixed some small things to make the code cleaner.
        - Turned some local variables into var's, such as `List<RadioMusic.Music.Playlist> radioPlaylists = new List<RadioMusic.Music.Playlist>();` turned into `var radioPlaylists = new List<RadioMusic.Music.Playlist>();`. Less code, looks more clean, and it's still easy to see what's going on.
        - Removed the `goto` statement and instead just added a found boolean that breaks the loop if it's true
        
14. Added try/catch statements to ApiClient.cs
        - Like the commit message says. I added some try/catch statements. I also changed `return null;` into `return new RadioMusic.Music.Playlist();` since the application crashes if you return null.
        
15. Fixed accidental API removal
        - I removed the API address in the previous commit for some testing and forgot to put it back.
        
16. Added (slightly broken) separator between channels
        - Added a separator between the channel list. It's not quite wide enough at the moment, but I will look into that later.
        
17. GetChannels() and GetPlaylists() now throws an exception if the HttpResponse isn't a success
        - What the message says. Instead of using `if (response.IsSuccessStatusCode)` i just do `response.EnsureSuccessStatusCode();` so that it throws a (handled) exception if it isn't a success.
        
##### 18. Merge branch 'feature/general-code-improvement' into dev
