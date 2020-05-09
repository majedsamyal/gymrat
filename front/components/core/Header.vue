<template>
  <nav class="navbar navbar-default navbar-fixed-top">
    <div class="container">
      <input type="checkbox" id="navbar-toggle-cbox">
      <div class="navbar-header">
        <label for="navbar-toggle-cbox" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
          <span class="sr-only">Toggle navigation</span>
          <span class="icon-bar"></span>
          <span class="icon-bar"></span>
          <span class="icon-bar"></span>
        </label>
        <a class="navbar-brand" href="#">Project name</a>
      </div>
      <div id="navbar" class="navbar-collapse collapse">
        <ul class="nav navbar-nav">
          <li class="active"><a href="#">Home</a></li>
          <li><a href="#about">About</a></li>
        </ul>
      </div>
      <!--/.nav-collapse -->
    </div>
  </nav>

</template>
<script>
export default {
  name: 'Header',
  head: {
   title: 'Gym management system',
   meta: [
     { name: 'description', content: 'Gym management system' },
     { name: 'author', content: 'Majed Samyal' },
     { name: 'keywords', content: 'Gym management, Healthclub management, Run successful Gym, Gymrat' }
   ],
   noscript: [
     { innerHTML: 'Body No Scripts', body: true }
   ]
 }
}
</script>

<style>
#navbar-toggle-cbox:checked ~ .collapse {
    display: block;
}

#navbar-toggle-cbox {
  display:none
}
</style>
