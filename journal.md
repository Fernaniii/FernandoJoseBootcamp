# JOURNAL

>06-11-2024
>i want to learn how to collaborate using github by learning pull push or something else
>06-14-2024
>github .md (markdown)


## git tricks
- you can use this instead of separate git add .  and git commit
   ```
  git commit -am "description"
   ```

- you can add allias to command to make the command faster
```
   git config --global allias.NAMEORLETTEROFNEWCOMMAND "COMMAND TO ALLIAS"   
```
 

### from local to remote
```
git init
git add .
git commit -m ."description"
git push
```

### from remote to local

    ```
     git remote add upstream [link]
     git fetch upstream
     git rebase upstream/main
    ```


### add ALERTS to Mark Down (.md)

``` 
> [!NOTE]
>Useful information that users should know, even when skimming content.

> [!TIP]
> Helpful advice for doing things better or more easily.

> [!IMPORTANT]
> Key information users need to know to achieve their goal.

> [!WARNING]
> Urgent info that needs immediate user attention to avoid problems.

> [!CAUTION]
> Advises about risks or negative outcomes of certain actions.

```
### EMOGI
:smile: 
```
:emoginame:

```

# TROUBLESHOOTING

  > [!NOTE] WHEN MULTIPLE PROJECT WITHIN A PROJECT FOLDER manually add solution
  > [MANUALLY ADDING SOLUTION](https://learn.microsoft.com/en-us/sql/ssms/solution/add-an-existing-project-to-a-solution?view=sql-server-ver16)


SEE [README.md](README.md)