<template>
    <button class="roundButton">+</button>
</template>

<script>

import { defineComponent } from 'vue';

export default defineComponent({

    data() {
        return {
        };
    },
    components: {}
});
</script>

<style scoped>
.roundButton {
    cursor: pointer;
    border-radius: 50%;
    height: 1vw;
    width: 1vw;
    margin-left: 5%;
    border: solid 3px #103941;
    font-size: 64px;
    font-weight: 600;
    background-color: #103941;
    color: white;
    display: flex;
    align-items: center;
    justify-content: center;
    transition: .3s ease-in-out;

    &:hover {
        background-color: white;
        color: #103941;
        border: solid 3px #103941;
    }
}
</style>