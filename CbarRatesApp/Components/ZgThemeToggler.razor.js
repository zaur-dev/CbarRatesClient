export function SetThemeAttribute(theme) {
    let doc = document.getElementsByTagName("html").item(0);
    doc.dataset.bsTheme = theme;
}

export function CheckColorScheme() {
    let isDark = window.matchMedia("(prefers-color-scheme: dark)").matches;
    return isDark;
}