# Xianxia IRL Quest for Programmer Flow!
Inspired by [Forge of Destiny] (https://www.royalroad.com/fiction/21188/forge-of-destiny)

## Steps of Black -> Red progression [Programmer Track - specialized in Fsharp / mono]

1. Basic familiarity with VIM
2. Basic familiarity with Mono FSharp
3. Basic familiarity with Git [^]
4. Write a small application in FSharp / Command Line

## Steps of Copper -> Gold progression [New Linux Hacker Track]

1. Basic familiarity with Bash
2. Basic familiarity with Grep
3. Basic familiarity with Remote Connections (ssh / vpn)
4. Basic familiarity with scripting language (perl / python)
5. Basic familiarity with awk & sed

## Elective Tracks - Choose 1 - 2 of these

### Steps of 0th -> 1st grade progression [Science / Data learning Track]

1. Basic familiarity with Python
2. Basic familiarity with numpy
3. Basic familiarity with Tensorflow
4. Write a small learning model in Python / Tensorflow

### Steps of H grade -> G grade progression [Web Learning Track]

1. Basic familiarity with HTML [^]
2. Basic familiarity with CSS
3. Basic familiarity with Postgres 
4. Basic familiarity with React


# Progress

Copper trial : troubleshooting failed update installation
[L0 - Hacker trial]
1. Package download sources
2. update manager vs. synaptic update manager
3. Broken packages

Black project : writing a small FSharp / Mono application
[L2 - Programmer Project]
Customizable Julian Day calculator

1. Modes
  * MM/DD - Normal (md-normal)
  * MM/DD - Leap (md-leap)
  * DD/MM - Normal (dm-normal)
  * DD/MM - Leap (dm-leap)
  * MM/DD/YYYY - Autocalc (mdy-auto)
  * DD/MM/YYYY - Autocalc (dmy-auto)
  * YYYY/MM/DD - Autocalc (ymd-auto)
2. User Input
  * MM/DD (Normal & Leap) : [md-normal, md-leap], month, day
  * DD/MM (Normal & Leap) : [dm-normal, dm-leap], day, month
  * MM/DD/YYYY : mdy-auto, month, day, year
  * DD/MM/YYYY : dmy-auto, day, month, year
  * YYYY/MM/DD : ymd-auto, year, month, day
3. Output / Function Definition
  * Displays the day number of the year (one-indexed)
  * For example: md-normal 1 1 returns 1 because January 1st is the first day of the year.
  * dm-leap 31 12 :--> 366
  * ymd-auto 1900 6 6 :--> 157
  * ymd-auto 2400 6 6 :--> 158
  * Despite being called Julian day its the Day of Year in the Gregorian calendar.
  * Still uses Gregorian 100/400 year even in pre-Gregorian times
4. Challenges
  * Track month length & year length for calculations
  * Watch out for off by one errors!
  * Don't use built in Datetime library
  * Command line argument processing
  * Parsing & Processing inputs
  * Error handling

Challenge Complete!

Insights -
 
  * Having multiple terminals open with learnblog.md, the source code and fsharp interactive is very handy.
  * If you use failwith for error control flow, ex.Message gives you the message you failed with.
  * VIM beginner insights:
    * o - add new line
    * dd - delete line
    * bn - next buffer
    * w - save
    * :saveas - save
    * yw - yank word
    * yy - yank line
    * :p - paste
  * FSharp notes
    * Active Pattern for parsing
    * Run mono command line apps with mono <app.exe> <params>

On the way home, you encountered a tribulation!
**Linux Mint refused to boot!**

Control-Alt-F1 to break into terminal
Logon Name: tony

Broken packages
Each package says it needs but cant install another.
It ends in a wonky version dispute

Lots of struggling to figure stuff out

The way out: sudo aptitude
Find gnome-online-accounts package
Remove corrupted dependent package
Reinstall gnome-online-accounts
Exit aptitude and install cinnamon-control-center
Install Cinnamon

Restart

Hmm, can't click on the terminal icon

**Cinnamon has crashed!**
Fallback mode

Oh yeah, what about timeshift!

**Do timeshift**

Timeshift goes back to the beginning of the problem.

Control-Alt-F1 
sudo aptitude
Can't find the gnome-online-accounts package!

Upgrade packages
*Do I have to them all by hand?*
Finds U button

Still can't find gnome-online-accounts
Oh, there is new-packages
Is that the right package
QQ to check
Oh yeah, its right

Fix gnome-online-accounts dependency
Reinstall
All is good

Cinnamon has crashed
**Accept your fate: learn Fallback mode**

Lose health (-5)
Crisis 1 - Partial Victory

**End Post 1**
