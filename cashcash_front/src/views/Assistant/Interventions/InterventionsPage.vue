<template>
    <SideBar></SideBar>

    <div class="wholePage">
        <SearchBar></SearchBar>
        <div style="margin-top: 2%;">
            <AddButton @click="addIntervention"></AddButton>
            <Intervention></Intervention>
            <Intervention></Intervention>
            <Intervention></Intervention>
        </div>
    </div>
</template>

<script>
import SideBar from '../../../components/Sidebar/SideBar.vue';
import Intervention from '../../../components/Intervention/InterventionAssistant.vue';
import AddButton from '../../../components/AddButton/AddButton.vue';
import SearchBar from '../../../components/Searchbar/SearchBar.vue';

import { defineComponent } from 'vue';

export default defineComponent({

    data() {
        return {
            user: {}
        };
    },
    methods: {
        addIntervention() {
            console.log('interventionajoutée')
        }
    },
    components: { SideBar, Intervention, SearchBar, AddButton }
});
</script>

<style scoped>
.wholePage {
    margin-left: 20%;
}


.roundButton {
    cursor: pointer;
    border-radius: 50%;
    height: 5vw;
    width: 5vw;
    margin-right: 2%;
    background-color: #103941;
    justify-content: center;
    transition: .3s ease-in-out;
}
</style>