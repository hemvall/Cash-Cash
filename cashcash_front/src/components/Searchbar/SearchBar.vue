<template>
    <div class="searchBarContainer">
        <input type="search" placeholder="Que souhaitez vous rechercher ?" />
        <a class="labelUser" style="display: flex;">{{ fonction }} - {{ username }} <a @click="logout()" style="margin-left: 25px;display: flex; align-items: center;"> <img
                    alt="logout icon" style="height: 25px;" src="../../assets/Icons/logout.svg" />
                Se déconnecter</a></a>
    </div>
</template>

<script>

import { defineComponent } from 'vue';

export default defineComponent({
    created(){
        this.fonction = localStorage.getItem('userFonction');
        this.username = localStorage.getItem('userName');
    },
    data() {
        return {
            username: '',
            fonction: '',
        };
    },
    methods: {
        logout() {
            localStorage.clear();
            location.reload();
        }
    },
    components: {}
});
</script>

<style scoped>
.searchBarContainer {
    background-color: #EFF0F1;
    color: black;
    box-sizing: border-box;

    padding: 1% 3%;
    display: flex;
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
    font-weight: 600;
}

.searchIcon {
    position: absolute;
    left: 23%;
}
</style>