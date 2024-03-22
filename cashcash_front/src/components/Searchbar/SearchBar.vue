<template>
    <div class="searchBarContainer">
        <input type="search" placeholder="Que souhaitez vous rechercher ?" />
        <img class="searchIcon" alt="search icon" src="../../assets/Icons/search.svg" />
        <a class="labelUser">{{ $store.state.userFonction }} - Antoine BLANQUAERT // logout</a>
    </div>
</template>

<script>

import { defineComponent } from 'vue';

export default defineComponent({

    data() {
        return {
        };
    },
    components: { }
});
</script>

<style scoped>
.searchBarContainer {
    background-color: #EFF0F1;
    color: black;
    box-sizing: border-box;

    padding: 1% 3%;
    display:flex;
    align-items: center;
    justify-content: space-between;
}

input {
    height: 1.7vw;
    border-radius: 5px;
    border: solid 1px #103941;
    background-color: #D9D9D9;
    width: 22%;
    padding-left: 3%;
}

.labelUser {
    font-weight:600;
}

.searchIcon {
    position: absolute; 
    left: 23%;
}
</style>