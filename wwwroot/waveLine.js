window.initWaveLine = () => {
    const page = document.querySelector(".decorated-page");
    const svg = document.querySelector(".wave-line");
    const path = document.querySelector("#wavePath");

    if (!page || !svg || !path) return;

    const resetLine = () => {
        const height = page.getBoundingClientRect().height;
        svg.setAttribute("viewBox", `0 0 80 ${height}`);
        path.setAttribute("d", `M40 0 C40 ${height / 3}, 40 ${height * 2 / 3}, 40 ${height}`);
    };

    resetLine();

    page.addEventListener("mousemove", (event) => {
        const rect = page.getBoundingClientRect();
        const y = event.clientY - rect.top;
        const height = rect.height;

        svg.setAttribute("viewBox", `0 0 80 ${height}`);

        const waveStrength = 34;
        const influence = 220;

        const y1 = Math.max(0, y - influence);
        const y2 = y;
        const y3 = Math.min(height, y + influence);

        const d = `
            M40 0
            C40 ${y1}, ${40 + waveStrength} ${y1}, ${40 + waveStrength} ${y2}
            C${40 + waveStrength} ${y3}, 40 ${y3}, 40 ${height}
        `;

        path.setAttribute("d", d);
    });

    page.addEventListener("mouseleave", resetLine);
};