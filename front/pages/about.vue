<div class="container">
<template>
  <div class="container-fluid">
  <h2>Three Equal Columns</h2>
  <p>Use the .col class on a specified number of elements and Bootstrap will recognize how many elements there are (and create equal-width columns). In the example below, we use three col elements, which gets a width of 33.33% each.</p>
  <div class="row">
    <div class="col bg-success">.col</div>
    <div class="col bg-warning">.col</div>
    <div class="col bg-success">.col</div>
  </div>
  </div>
  </div>
</template>
<script lang="ts">
import Vue from 'vue'
import bootstrap from 'bootstrap';

export default Vue.extend({
  components: {
  }
})
</script>
