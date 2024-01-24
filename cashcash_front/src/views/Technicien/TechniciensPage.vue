<template>
    <SideBar></SideBar>

        <div class="wholePage">
            <SearchBar></SearchBar>
            <div style="margin-top: 4%;">
                <Technicien></Technicien>
            </div>
        </div>
</template>

<script>
import SideBar from '../../components/Sidebar/SideBar.vue';
import Technicien from '../../components/Technicien/Technicien.vue';
import SearchBar from '../../components/Searchbar/SearchBar.vue';

import { defineComponent } from 'vue';

export default defineComponent({

    data() {
        return {
            user: {}
        };
    },
    components: { SideBar, Technicien, SearchBar }
});
</script>

<style scoped>
.wholePage{
    margin-left: 20%;
}
</style>