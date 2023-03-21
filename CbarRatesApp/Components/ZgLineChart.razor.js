export function setup(id, config) {
    const ctx = document.getElementById(id).getContext('2d');
    new Chart(ctx, config);
}