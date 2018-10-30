# CLM2018GameJam
An unofficial submission from UC Davis's Computer Lab Managment. This is not sponsored at all by the university, completely a labor of love from the employees of Fall 2018.

## Descritpion 

Description and end-goal of the game will go here.


### Workflow Guidlines
Meant as a guide to those who are new to Git, working in a team, or both. 

Git supports _branching_. It basically means that you can work on a seperate part of the project without interfering with the _master_ branch. **You'll want to create a new branch and switch to it whenever you start to work on something.** As a rule of thumb, the master branch should always be deployable.

#### Adding, and commiting your work
While you may be saving your work to your local filesystem, you'll eventually want to tell the remote repository that you have changed some files, so that others can use/see what you have. To tell git that you have work that you want to add to a commit, type `git add filename1 filename2 ...`. This will add these files to the index. The index is just a way that git can tell what was added, removed, and modified. To get ready to push this to the remote, type `git commit -m "Message`, where message is a short, descriptive message of what was changed. You should commit often to keep these messages more specific. To push this to the repo, use `git push`.

#### Branching
To create a branch, type into your terminal `git branch name-of-your-branch` then switch to it using `git checkout name-of-your-branch`. From there, you can type `git status` to confirm that you have created and switch branches. Use `git checkout branch-name` to swap to any branch. Follow the steps for commiting and pushing to send your work to the remote repository.


### Naming Conventions
– Functions: Pascal case
– Type Names: T prepended to Pascal case
– Defines: Screaming snake case
– StructNames: S prepended to Pascal case
– Class Names: C prepended to Pascal case
– Data Members: D prepended to Pascal case
– EnumNames: E prepended to Pascal case
– Enumerated Values: enumclasses with Pascal case
– Local Variables: Pascal case
– Global Variables: G prepended to Pascal case
– Parameters: Lowercase


### Authors (needs roles later)
Chase Maguire : https://github.com/Wirdal 

Ben Larrissson: https://github.com/bllarrison

Noah Grove: https://github.com/kuesa

Shashank Shastry : https://github.com/greyhat36

Vanessa Kha : https://github.com/vanessakha

Maxim Chiao : https://github.com/mwchiao

Patrick Day : https://github.com/Phat-Pat

Cindy Hoang : https://github.com/CindyHoang

Yashdeep Sidana: https://github.com/yssidana

Jerico Horca : https://github.com/DoctorRiceYouSee
