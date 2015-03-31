Test repo for http://stackoverflow.com/questions/29362462/visual-studio-2013-issue-in-the-webjobs-deployment-logic-with-resx

There is a solution with two projects: a website and a webjob.

I've added the webjob to the website with the "add existing project as a webjob" VS functionality.

The webjob is an extremely simple console project that prints a "Hello World" in two languages using .resx files

Everything works ok when I launch the console project in my local machine.

The problem occurs when I publish the website (it doesn't matter if I publish on the file system, azure website, etc., the same thing happens): the webjob is published to the website AppData folder as suposed, but it doesn't include the localization folders. The result is that the published webjob in the AppData website print the "Hello World" twice, but in the neutral language.

You only need to clone it, execute the console project to check the correct behaviour and then publish the website. You'll see the webjob in the AppData folder, execute it and you'll see the incorrect behaviour.

I've attached some screenshots (https://github.com/subgurim/WebJobLocalizationTests/tree/master/WebJobLocalizationTests/Screenshots)

Thanks!