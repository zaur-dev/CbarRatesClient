export function setThemeAttribute(theme) {
    const doc = document.getElementsByTagName("html").item(0);
    doc.dataset.bsTheme = theme;
}

export function checkColorScheme() {
    return window.matchMedia("(prefers-color-scheme: dark)").matches;
}