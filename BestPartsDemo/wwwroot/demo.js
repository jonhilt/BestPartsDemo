document.addEventListener('visibilitychange', ()=> {
    if(document.hidden) {
        console.debug("Document hidden - pausing Blazor");
        Blazor.pauseCircuit();
    } else {
        console.debug("Document visible - resuming Blazor");
        Blazor.resumeCircuit();
    }
});