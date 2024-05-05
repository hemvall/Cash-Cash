<template>
    <SideBar></SideBar>

    <div class="wholePage">
        <SearchBar></SearchBar>
        <div style="margin-top: 2%;">
            <AddButton @click="addClient"></AddButton>
            <Client></Client>
        </div>
    </div>
</template>

<script>
import SideBar from '../../../components/Sidebar/SideBar.vue';
import Client from '../../../components/';
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
        addClient() {
            const requestOptions = {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify({
                    techId: 0,
                    contratId: 0,
                    commentaire: 'N/D',
                    etat: 'Planifié',
                    dateClient: Date.now()
                })
            };
            fetch(`${this.$api}/Client`, requestOptions)
                .then(response => {
                    if (response.ok) { alert("L'Client a bien été créee") }
                    else { alert("L'Client n'a pas été créee") }
                })
        }
    },
    components: { SideBar, Client, SearchBar, AddButton }
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