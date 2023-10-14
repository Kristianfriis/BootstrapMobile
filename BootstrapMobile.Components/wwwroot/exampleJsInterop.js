// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function showPrompt(message) {
  return prompt(message, 'Type anything here');
}

export function CanGoBack() {
    history.back();
}

export function toggleOffCanvas(el) {
    const myOffcanvas = document.getElementById(el.id)

    myOffcanvas.toggle();
}

export function setThemeColor(color) {
    document.querySelector("meta[name='theme-color']").content = color;
}