# GitHub CI/CD Course Creation Instructions
## Template for Future Course Development

### Course Context
**Target Audience**: .NET/C# developers transitioning to GitHub CI/CD
**Team Structure**: Small teams (~5 developers) within large organizations
**Experience Level**: Foundation level (basic GitHub knowledge assumed)

### Core Course Parameters
- **Duration**: Each module ≤ 60 minutes
- **Structure**: 5 modules with Concepts → Practice → Team Scenarios → Validation
- **Repository Approach**: Students create their own practice repositories
- **Application Type**: Basic .NET Web API for hands-on labs

### Prerequisites (Assumed Knowledge)
- Basic GitHub operations (commit, push, branch creation)
- Git commands (pull, merge, fetch, commit)
- .NET CLI commands (dotnet build, dotnet test, dotnet run)  
- Basic YAML syntax (but not GitHub Actions YAML specifically)
- C# programming fundamentals

### Module Structure Template
Each module should include:
1. **Learning Objectives** (clear, measurable outcomes)
2. **Concepts** (15-20 minutes) - terminology, theory, best practices
3. **Practice Lab** (25-35 minutes) - hands-on implementation
4. **Team Scenario** (5-10 minutes) - hypothetical multi-developer situations
5. **Validation Questions** (5 minutes) - concept comprehension checks

### Core Topics to Cover (Version 1)
1. **Team Workflows & Branching Strategy**
   - Use GitHub Flow (feature branching)
   - Branch naming conventions
   - Pull Request workflows
   - Code review practices

2. **GitHub Actions Fundamentals**
   - Terminology alignment (workflows, jobs, steps, actions, runners)
   - YAML workflow creation
   - Triggers and basic debugging

3. **CI Pipeline Implementation**
   - Build automation
   - Unit testing integration (xUnit)
   - Code coverage concepts and enforcement
   - Test result reporting

4. **Multi-Environment CD Pipelines**
   - Environment-agnostic deployment concepts
   - Dev, Staging, Production progression
   - Manual approvals and deployment gates

5. **Team Collaboration Scenarios**
   - Real-world application of all concepts
   - Troubleshooting common issues
   - Communication protocols

### Required Course Elements
- **Terminology Focus**: Correct improper usage throughout; create glossary with examples
- **Visual Aids**: Include Mermaid diagrams for workflows and processes
- **Environment Strategy**: Dev → Staging → Production (stay environment-agnostic initially)
- **Assessment Method**: Validation questions for comprehension checking
- **Future Planning**: Maintain list of advanced topics for subsequent versions

### Items to Defer to Future Versions
- Hotfix orchestration workflows
- Azure-specific deployment targets  
- Linting & style enforcement
- GitHub Secrets & security practices
- Dependency scanning & vulnerability alerts
- Advanced branching strategies (GitFlow, trunk-based)
- Advanced testing strategies

### Course Completion Criteria
Students should be able to:
- Explain chosen branching strategy and its benefits
- Create and configure basic GitHub Actions workflows
- Integrate automated testing into CI pipelines
- Design multi-environment deployment strategies  
- Troubleshoot common workflow failures
- Use proper CI/CD terminology consistently

### Customization Variables for Future Use
**Team Size**: Currently 5 developers (adjust team scenarios accordingly)
**Testing Framework**: Currently xUnit (swap for NUnit, MSTest, etc.)
**Application Type**: Currently Web API (could be Console, MVC, etc.)
**Cloud Platform**: Currently environment-agnostic (specify Azure, AWS, etc.)
**Branching Strategy**: Currently GitHub Flow (could be GitFlow, etc.)

### Quality Standards
- Each module must be completable within time constraint
- Include both conceptual learning and practical application
- Provide realistic team scenarios that reflect target audience
- Maintain consistent terminology throughout
- Include troubleshooting guidance for common issues
- Balance automation concepts with human oversight needs

### Reuse Instructions
1. Copy this template
2. Adjust customization variables as needed
3. Modify team scenarios to match new context
4. Update hands-on labs for different tech stacks
5. Adjust prerequisites based on target audience
6. Modify course completion criteria accordingly
7. Update deferred items list based on new priorities

### Example Modifications for Different Contexts
**For Node.js/JavaScript**: Change .NET CLI to npm/yarn, xUnit to Jest, Web API to Express
**For Larger Teams**: Adjust branching strategy to GitFlow, add more complex review processes
**For Azure Focus**: Add Azure-specific deployment steps, ARM templates, Azure Container Registry
**For Security Focus**: Move security topics from "future versions" to core curriculum