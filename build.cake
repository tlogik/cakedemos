var target = Argument("targer", "Default");

Task("Default").IsDependentOn("Build");

Task("Build").Does(() => {
    MSBuild("./src/CakeDemo.sln")
});

RunTarget(target);
