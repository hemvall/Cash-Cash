<template>
</template>

<script>
import html2pdf from "html2pdf.js";

export default {
    name: "app",
    methods: {
        exportToPDF() {
            html2pdf(document.getElementById("element-to-convert"), {
                margin: 1,
                filename: "i-was-html.pdf",
            });
        },
    },
};
</script>

<style>
#app {
    text-align: center;
}
</style>