<template>
    <SideBar></SideBar>
    <!--  <div style="display: block;">
            <SearchBar style="margin-left: 20%;"></SearchBar>
            <AssistantDashboardTop style="margin-left: 20%;"></AssistantDashboardTop>
        </div> -->
        <div class="wholePage">
            <SearchBar></SearchBar>
            <AssistantDashboardTop></AssistantDashboardTop>
        </div>
</template>

<script>
import SideBar from '../../components/Sidebar/SideBar.vue';
import AssistantDashboardTop from '../../components/AssistantDashboardTop/AssistantDashboardTop.vue';
import SearchBar from '../../components/Searchbar/SearchBar.vue';
import { defineComponent } from 'vue';

export default defineComponent({

    data() {
        return {
            user: {}
        };
    },
    components: { SideBar, AssistantDashboardTop, SearchBar }
});
</script>

<style scoped>
.wholePage{
    margin-left: 20%;
}
</style>