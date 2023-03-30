export function setThemeAttribute(theme) {
    const doc = document.getElementsByTagName("html").item(0);

    doc.dataset.bsTheme = theme;

    const navBar = document.getElementById("nav");
    if (theme === "dark") {
        navBar.classList.remove("bg-light");
        navBar.classList.add("bg-dark");
    } else {
        navBar.classList.remove("bg-dark");
        navBar.classList.add("bg-light");
    }
}

export function checkColorScheme() {
    return window.matchMedia("(prefers-color-scheme: dark)").matches;
}