Git Helpers
===========

## Introduction

_git-helpers_ intents to be a set of helper commands and utilities to simplify to working with MakingSense flows.

## Git commands

### ffetch

Update local `develop`, `integration` and `qa` from `upstream` repository and also related TFS checkins.

It is useful to mitigate a _git-tfs_ issue that generates duplicated commits: [#576 - Scan downstream for commits when fetching](https://github.com/git-tfs/git-tfs/issues/576).

```
git ffetch
```

#### Warnings

* It reset all not committed changes
* It reset `develop`, `integration` and `qa` branches to `upstream` commits, losing any other commit.

#### Limitations

* After finish it does not restore HEAD to previous branch, it sets HEAD to `develop`
* Upstream remote should be named `upstream`
* Branches `develop`, `integration` and `qa` should exist on `upstream`
* TFS remotes should be `tfs/default`, `tfs/integration` and `tfs/qa`

#### Dependencies

* Requieres [git-tfs](http://git-tfs.com/)



