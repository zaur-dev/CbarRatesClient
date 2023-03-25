var chart;

export function setup(id, config) {
    const ctx = document.getElementById(id).getContext('2d');
    chart = new Chart(ctx, config);
}

export function update(id, config) {
    
    chart.data = config.data;
    chart.update();
}


