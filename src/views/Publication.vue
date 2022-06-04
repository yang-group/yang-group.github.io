<template>
  <v-main class="publication">
    <h1>Publications</h1>
    <v-container class="">
      <v-row>
        <v-col v-for="(paper, i) in papers" :key="i" cols="auto" md="10" >
          <v-card height="200" flat>
            <Paper :paper="paper" />
          </v-card>
        </v-col>
      </v-row>
    </v-container>
  </v-main>
</template>
<script>
import YAML from 'yamljs'
import Paper from '@/components/Paper'
var nativeObject = YAML.load('./data/data.yml')
var jsonstr = JSON.stringify(nativeObject)
var jsondata = JSON.parse(jsonstr)

export default {
  components: { Paper },
  data: () => ({
    papers: jsondata.paperList
  })
}

</script>
<style lang="css" scoped>
.publication{
  max-width: 1185px;
  margin: auto;
}
</style>
