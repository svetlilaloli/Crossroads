Console Application<br>
Exercise: Stacks and Queues
# Crossroads
Our favorite super-spy action hero Sam is back from his mission in the previous exam, and he has finally found some time to go on a __holiday__. He is taking his wife somewhere nice and they’re going to have a really good time, but first, they have to get there. Even on his holiday trip, Sam is still going to run into some __problems__ and the first one is, of course, getting to the airport. Right now, he is stuck in a traffic jam at a __very active crossroads__ where a lot of __accidents happen__.<br><br>
Your job is to keep track of traffic at the crossroads and report whether a __crash happened__ or everyone __passed__ the __crossroads safely__ and our hero is one step closer to a much desired vacation.<br><br>
The road Sam is on has a __single lane__ where cars queue up until the __light goes green__. When it does, they start passing one by one during the __green light__ and the __free window__ before the __intersecting road’s light__ goes __green__. During __one second__ only __one part__ of a __car__ (a __single character__) passes the crossroads. If a car is still in the crossroads when the __free window__ ends, it will get hit at the __first character__ that is still in the crossroads.
## Input
- On the __first line__, you will receive the duration of the __green light__ in seconds – an __integer in the range [1-100]__
- On the __second line__, you will receive the duration of the __free window__ in seconds – an __integer in the range [0-100]__
- On the __following lines__, until you receive the "__END__" command, you will receive one of two things:
  - A __car__ – a __string__ containing any ASCII character, or
  - The command "__green__" which indicates the __start__ of a __green light cycle__
A __green light cycle__ goes as follows:
- During the __green light__ cars will enter and exit the crossroads one by one
- During the __free window__ cars will only exit the crossroads
## Output
- If a __crash happens__, __end the program and print__:
"__A crash happened!__"
"__{car} was hit at {characterHit}.__"
- If everything __goes smoothly__ and you receive an "__END__" command, print:
"__Everyone is safe.__"
"__{totalCarsPassed} total cars passed the crossroads.__"
## Constraints
- The input will be __within the constaints__ specified above and will __always be valid__. There is __no need__ to check it explicitly.
## Examples
Input|Output|Comments
-----|------|--------
10<br>5<br>Mercedes<br>green<br>Mercedes<br>BMW<br>Skoda<br>green<br>END|Everyone is safe.<br>3 total cars passed the crossroads.|During the first green light (10 seconds), the Mercedes (8) passes safely.<br>During the second green light, the Mercedes (8) passes safely and there<br> are 2 seconds left. The BMW enters the crossroads and when the green<br> light ends, it still has 1 part inside ('W'), but has 5 seconds<br> to leave and passes successfully. The Skoda never enters the crossroads,<br> so 3 cars passed successfully.
9<br>3<br>Mercedes<br>Hummer<br>green<br>Hummer<br>Mercedes<br>green<br>END|A crash happened!<br>Hummer was hit at e.|Mercedes (8) passes successfully and Hummer (6) enters the crossroads<br> but only the 'H' passes during the green light. There are 3 seconds of free window,<br> so "umm" passes and the Hummer gets hit at 'e' and the program ends with a crash.
