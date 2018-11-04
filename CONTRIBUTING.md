

### Workflow Guidlines
Meant as a guide to those who are new to Git, working in a team, or both. 

Git supports _branching_. It basically means that you can work on a seperate part of the project without interfering with the _master_ branch. **You'll want to create a new branch and switch to it whenever you start to work on something.** As a rule of thumb, the master branch should always be deployable.

#### Adding, and commiting your work
While you may be saving your work to your local filesystem, you'll eventually want to tell the remote repository that you have changed some files, so that others can use/see what you have. To tell git that you have work that you want to add to a commit, type `git add filename1 filename2 ...`. This will add these files to the index. The index is just a way that git can tell what was added, removed, and modified. To get ready to push this to the remote, type `git commit -m "Message`, where message is a short, descriptive message of what was changed. You should commit often to keep these messages more specific. To push this to the repo, use `git push`.

#### Branching
You will want to branch, so that you are not working on the master branch. To create a branch, type into your terminal `git branch name-of-your-branch` then switch to it using `git checkout name-of-your-branch`. From there, you can type `git status` to confirm that you have created and switch branches. Use `git checkout branch-name` to swap to any branch. Follow the steps for commiting and pushing to send your work to the remote repository.

#### Issues
Please use the templates when creating issues. If you would like to suggest a new template, talk to Chase

#### Projects
Projects are rough ideas of who is working in what group. While the groups are far from set in stone, it gives and idea of who is working on what. They allow 3 states of a feature, TODO, In Progress, and Done. You can edit the specific card to update progress and suggest how to do/fix it. Click and drag it to update it to the correct status.

#### Creating Pull Requests
Same as the issues, follow the template when making PRs. Don't merge it yourself

#### Reviewing PRs
Please be kind and corteous. Constructive criticism is best when there is something not right. At least one person should review a PR (besides the creator) and all reviews should approve before merging. Choose the option to squash commits, so it does not bloat up master.

### Naming Conventions
- Functions: Pascal case
- Type Names: T prepended to Pascal case
- Defines: Screaming snake case
- StructNames: S prepended to Pascal case
- Class Names: C prepended to Pascal case
- Data Members: D prepended to Pascal case
- EnumNames: E prepended to Pascal case
- Enumerated Values: enumclasses with Pascal case
- Local Variables: Pascal case
- Global Variables: G prepended to Pascal case
- Parameters: Lowercase
